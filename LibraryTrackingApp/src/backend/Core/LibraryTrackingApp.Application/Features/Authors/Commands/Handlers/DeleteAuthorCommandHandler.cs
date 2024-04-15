using LibraryTrackingApp.Application.Features.Authors.Commands.Requests;
using LibraryTrackingApp.Application.Features.Authors.Commands.Responses;
using LibraryTrackingApp.Application.Features.Books.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Authors.Commands.Handlers;


public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommandRequest, DeleteAuthorCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    public DeleteAuthorCommandHandler(IUnitOfWork<Guid> unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<DeleteAuthorCommandResponse> Handle(DeleteAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {

            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.Author>();

            Guid bookId;
            bool isGuid = Guid.TryParse(request.Id, out bookId);

            var existingAuthor = await readRepository.GetSingleAsync(s => isGuid && s.Id == bookId);

            if (existingAuthor == null)
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
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.Author>();
                bool isDeleted = await writeRepository.DeleteAsync(existingAuthor);
                if (isDeleted)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Yazar başarıyla silindi." }
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
            return new ()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new string[] { $"Yazar silinirken bir hata oluştu: {ex.Message}" }
            };
        }
    }
}