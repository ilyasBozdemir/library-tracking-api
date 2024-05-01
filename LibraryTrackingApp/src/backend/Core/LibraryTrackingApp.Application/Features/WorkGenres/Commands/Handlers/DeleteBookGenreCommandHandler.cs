using LibraryTrackingApp.Application.Features.WorkGenres.Commands.Requests;
using LibraryTrackingApp.Application.Features.WorkGenres.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Commands.Handlers;


public class DeleteBookGenreCommandHandler : IRequestHandler<DeleteBookGenreCommandRequest, DeleteBookGenreCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public DeleteBookGenreCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<DeleteBookGenreCommandResponse> Handle(DeleteBookGenreCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {

            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.WorkGenre>();

            Guid bookId;
            bool isGuid = Guid.TryParse(request.Id, out bookId);

            var existingBookGenre = await readRepository.GetSingleAsync(s => isGuid && s.Id == bookId);

            if (existingBookGenre == null)
            {
                return new()
                {
                    StatusCode = 404,
                    Success = false,
                    StateMessages = new string[] { "Tür bulunamadı" }
                };
            }
            else
            {
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.WorkGenre>();
                bool isDeleted = await writeRepository.DeleteAsync(existingBookGenre);
                if (isDeleted)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Tür başarıyla silindi." }
                    };
                }
                else
                {

                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Tür silinirken bir hata oluştu." }
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
                StateMessages = new string[] { $"Tür silinirken bir hata oluştu: {ex.Message}" }
            };
        }
    }
}