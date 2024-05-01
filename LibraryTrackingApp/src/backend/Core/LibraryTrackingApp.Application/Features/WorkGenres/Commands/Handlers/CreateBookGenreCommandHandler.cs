using LibraryTrackingApp.Application.Features.WorkGenres.Commands.Requests;
using LibraryTrackingApp.Application.Features.WorkGenres.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Commands.Handlers;


public class CreateBookGenreCommandHandler : IRequestHandler<CreateBookGenreCommandRequest, CreateBookGenreCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public CreateBookGenreCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<CreateBookGenreCommandResponse> Handle(CreateBookGenreCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var existinBookGenre = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.WorkGenre>()
                .ExistsAsync(b =>
                b.Name == request.Name
                );

            if (existinBookGenre)
            {
                return new()
                {
                    StatusCode = 409,
                    Success = false,
                    StateMessages = new string[] { "Bu bilgilere sahip bir tür zaten mevcut." }
                };
            }
            var newBookGenre = new Domain.Entities.Library.WorkGenre()
            {
                Name = request.Name,
                IsActive = request.IsActive,
                IsDeleted = false,
                CreatedById = Guid.NewGuid(),//staff id olucak ilerde
                LastModifiedById = Guid.NewGuid(),//staff id olucak ilerde
                LastModifiedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
                CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            };

            var bookDto = new BookGenreDTO()
            {
                Name = request.Name,
                IsActive = request.IsActive,
            };

            var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.WorkGenre>();
            bool isAdded = await writeRepository.AddAsync(newBookGenre);
            if (isAdded)
            {
                return new()
                {
                    StatusCode = 201,
                    Success = true,
                    StateMessages = new string[] { "Tür başarıyla oluşturuldu." }
                };
            }
            else
            {

                return new()
                {
                    StatusCode = 400,
                    Success = false,
                    StateMessages = new string[] { "Tür eklenirken bir hata oluştu." }
                };
            }

        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}