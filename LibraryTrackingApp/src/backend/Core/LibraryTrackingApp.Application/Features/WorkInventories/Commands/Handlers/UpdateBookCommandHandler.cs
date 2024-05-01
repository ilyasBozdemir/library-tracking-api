using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Requests;
using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Commands.Handlers;

public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommandRequest, UpdateBookCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;

    public UpdateBookCommandHandler(IUnitOfWork<Guid> unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<UpdateBookCommandResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.WorkCatalog>();

            var existingBook = await readRepository.GetSingleAsync(s => s.Id == request.Id);

            if (existingBook == null)
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

                existingBook.Title = request.Title;
                existingBook.ISBN = request.ISBN;
                existingBook.PageCount = request.PageCount;
                //existingBook.PublicationDate = request.PublicationDate;
                existingBook.WorkStatus = request.Status;
                existingBook.Summary = request.Summary;
                existingBook.OriginalPublicationDate = request.OriginalPublicationDate;
                existingBook.WorkFormat = request.WorkFormat;
                existingBook.WorkLanguage = request.BookLanguage;
                existingBook.GenreId = request.GenreId;
                existingBook.PublisherId = request.PublisherId;
                existingBook.AuthorId = request.AuthorId;
                existingBook.LibraryBranchId = request.LibraryBranchId;


                bool isUpdated = await writeRepository.UpdateAsync(existingBook);

                if (isUpdated)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Kitap başarıyla güncellendi." }
                    };
                }
                else
                {

                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Kitap güncellenirken bir hata oluştu." }
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
                StateMessages = new string[] { $"Kitap güncellenirken bir hata oluştu: {ex.Message}" },
            };
        }
    }
}
