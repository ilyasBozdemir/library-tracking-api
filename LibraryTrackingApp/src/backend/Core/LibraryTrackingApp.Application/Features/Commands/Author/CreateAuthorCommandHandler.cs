using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.Author;


public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest, CreateAuthorCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public CreateAuthorCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<CreateAuthorCommandResponse> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var existingAuthor = await _unitOfWork.GetReadRepository<Domain.Entities.Library.Author>()
                .ExistsAsync(b => 
                b.Name == request.Name 
                && b.Surname == request.Surname 
                && b.Country == request.Country
                && b.BirthDate == request.BirthDate
                );

            if (existingAuthor)
            {
                return new()
                {
                    StatusCode = 409,
                    Success = false,
                    StateMessages = new string[] { "Bu bilgilere sahip bir yazar zaten mevcut." }
                };
            }
            var newAuthor = new Domain.Entities.Library.Author()
            {
                Name = request.Name,
                Surname = request.Surname,
                Country = request.Country,
                BirthDate = request.BirthDate,
                Biography = request.Biography,
                IsDeleted = false,
                DeletedDate = null,
                CreatedBy="test-user",//staff name olucak ilerde
                LastModifiedBy= "test-user",//staff name olucak ilerde
                LastModifiedDate =DateTime.Now,
                CreatedDate= DateTime.Now,
            };

            var bookDto = new AuthorDTO()
            {
                Name = request.Name,
                Surname = request.Surname,
                Country = request.Country,
                BirthDate = request.BirthDate,
                Biography = request.Biography,
            };

            var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.Author>();
            bool isAdded = await writeRepository.AddAsync(newAuthor);
            if (isAdded)
            {
                return new()
                {
                    StatusCode = 200,
                    Success = true,
                    StateMessages = new string[] { "Yazar başarıyla eklendi." }
                };
            }
            else
            {

                return new()
                {
                    StatusCode = 400,
                    Success = false,
                    StateMessages = new string[] { "Yazar eklenirken bir hata oluştu." }
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