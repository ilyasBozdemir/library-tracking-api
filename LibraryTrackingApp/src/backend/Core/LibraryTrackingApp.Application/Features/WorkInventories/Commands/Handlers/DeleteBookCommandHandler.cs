using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Requests;
using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Commands.Handlers;


public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    public DeleteBookCommandHandler(IUnitOfWork<Guid> unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {

            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.WorkCatalog>();

            Guid bookId;
            bool isGuid = Guid.TryParse(request.IdOrISBN, out bookId);

            var existingBookStock = await readRepository.GetSingleAsync(s =>
                isGuid && s.Id == bookId ||
                !isGuid && s.ISBN == request.IdOrISBN
            );

            if (existingBookStock == null)
            {
                return new()
                {
                    StatusCode = 404,
                    Success = false,
                    StateMessages = new string[] { "Böyle bir kitap bulunamadı" }
                };
            }
            else
            {
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.WorkCatalog>();
                bool isDeleted = await writeRepository.DeleteAsync(existingBookStock);
                if (isDeleted)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Kitap başarıyla silindi." }
                    };
                }
                else
                {

                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Kitap silinirken bir hata oluştu." }
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
                StateMessages = new string[] { $"Kitap silinirken bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
