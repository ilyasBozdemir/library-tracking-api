using LibraryTrackingApp.Application.Features.BookGenres.Commands.Requests;
using LibraryTrackingApp.Application.Features.BookGenres.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities;

namespace LibraryTrackingApp.Application.Features.BookGenres.Commands.Handlers;


public class UpdateBookGenreCommandHandler : IRequestHandler<UpdateBookGenreCommandRequest, UpdateBookGenreCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public UpdateBookGenreCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<UpdateBookGenreCommandResponse> Handle(UpdateBookGenreCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.WorkGenre>();

            var existingBookGenre = await readRepository.GetSingleAsync(s => s.Id == request.UpdatedId);
            if (existingBookGenre == null)
            {
                return new()
                {
                    StatusCode = 404,
                    Success = false,
                    StateMessages = new string[] { "Böyle bir yazar bulunamadı" }
                };
            }
            else
            {
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.WorkGenre>();

                existingBookGenre.Name = request.Name;
                existingBookGenre.IsActive = request.IsActive;
                existingBookGenre.CreatedById = Guid.NewGuid();//staff id olucak ilerde
                existingBookGenre.LastModifiedById = Guid.NewGuid();//staff id olucak ilerde
                existingBookGenre.LastModifiedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now);
                existingBookGenre.CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now);

                bool isUpdated = await writeRepository.UpdateAsync(existingBookGenre);

                if (isUpdated)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Tür başarıyla güncellendi." }
                    };
                }
                else
                {

                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Tür güncellenirken bir hata oluştu." }
                    };
                }
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