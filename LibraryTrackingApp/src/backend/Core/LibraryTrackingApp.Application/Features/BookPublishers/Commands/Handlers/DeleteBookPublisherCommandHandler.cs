using LibraryTrackingApp.Application.Features.BookPublishers.Commands.Requests;
using LibraryTrackingApp.Application.Features.BookPublishers.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Commands.Handlers;


public class DeleteBookPublisherCommandHandler : IRequestHandler<DeleteBookPublisherCommandRequest, DeleteBookPublisherCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public DeleteBookPublisherCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<DeleteBookPublisherCommandResponse> Handle(DeleteBookPublisherCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {

            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.WorkPublisher>();

            Guid bookId;
            bool isGuid = Guid.TryParse(request.Id, out bookId);

            var existingBookPublisher = await readRepository.GetSingleAsync(s => isGuid && s.Id == bookId);

            if (existingBookPublisher == null)
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
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.WorkPublisher>();
                bool isDeleted = await writeRepository.DeleteAsync(existingBookPublisher);
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
                        StateMessages = new string[] { "Yazar silinirken bir hata oluştu." }
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