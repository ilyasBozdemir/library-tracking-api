using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.Book.UpdateBook
{
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
                // Kitap güncelleme işlemi burada gerçekleştirilecek
                // Örneğin, kitabın veritabanındaki bilgilerini güncelleme ve işlem sonucunu değerlendirme

                // var bookToUpdate = await _unitOfWork.BookRepository.GetByIdAsync(request.BookId);
                // if (bookToUpdate == null)
                // {
                //     return new UpdateBookCommandResponse
                //     {
                //         StatusCode = 404,
                //         Success = false,
                //         Message = "Güncellenecek kitap bulunamadı."
                //     };
                // }

                // bookToUpdate.Title = request.NewTitle;
                // bookToUpdate.Author = request.NewAuthor;
                // bookToUpdate.ISBN = request.NewISBN;
                // vb.

                // await _unitOfWork.SaveChangesAsync();

                // Güncelleme işlemi başarılıysa
                return new UpdateBookCommandResponse
                {
                    StatusCode = 200,
                    Success = true,
                    Errors = new string[] { "Kitap başarıyla güncellendi." }
                };
            }
            catch (Exception ex)
            {
                // Güncelleme işlemi sırasında bir hata oluşursa
                return new UpdateBookCommandResponse
                {
                    StatusCode = 500,
                    Success = false,
                    Errors = new string[] { $"Kitap güncellenirken bir hata oluştu: {ex.Message}" },
                };
            }
        }
    }
}
