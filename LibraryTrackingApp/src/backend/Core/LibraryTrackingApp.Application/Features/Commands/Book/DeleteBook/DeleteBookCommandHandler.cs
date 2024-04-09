using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.Book.DeleteBook;


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
            // Kitap silme işlemi burada gerçekleştirilecek
            // Örneğin, kitabı veritabanından silme ve işlem sonucunu değerlendirme

            // _unitOfWork.BookRepository.DeleteBook(request.BookId);
            // await _unitOfWork.SaveChangesAsync();

            // Silme işlemi başarılıysa
            return new DeleteBookCommandResponse
            {
                StatusCode = 200,
                Success = true,
                Errors = new string[] { "Kitap başarıyla silindi." }
            };
        }
        catch (Exception ex)
        {
            // Silme işlemi sırasında bir hata oluşursa
            return new DeleteBookCommandResponse
            {
                StatusCode = 500,
                Success = false,
                Errors = new string[] { $"Kitap silinirken bir hata oluştu: {ex.Message}" }
            };
        }

        return new()
        {
            StatusCode = 200,
            Success = true,
        };
    }
}
