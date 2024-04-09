using LibraryTrackingApp.Application.Features.Events.Book;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.BookStock.DeleteBookStock
{
    public class DeleteBookStockCommandHandler : IRequestHandler<DeleteBookStockCommandRequest, DeleteBookStockCommandResponse>
    {
        private readonly IUnitOfWork<Guid> _unitOfWork;
        private readonly IMediator _mediator;

        public DeleteBookStockCommandHandler(IUnitOfWork<Guid> unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public async Task<DeleteBookStockCommandResponse> Handle(DeleteBookStockCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                // Kitap stok silme işlemi burada gerçekleştirilecek
                // Örneğin, kitap stoğunun veritabanından silinmesi ve işlem sonucunun değerlendirilmesi

                // var bookStockToDelete = await _unitOfWork.BookStockRepository.GetByIdAsync(request.BookStockId);
                // if (bookStockToDelete == null)
                // {
                //     return new DeleteBookStockCommandResponse
                //     {
                //         StatusCode = 404,
                //         Success = false,
                //         Errors = new string[] { "Silinecek kitap stoku bulunamadı." }
                //     };
                // }

                // _unitOfWork.BookStockRepository.Delete(bookStockToDelete);
                // await _unitOfWork.SaveChangesAsync();

                // Kitap stok silme işlemi başarılıysa
                return new DeleteBookStockCommandResponse
                {
                    StatusCode = 200,
                    Success = true,
                    Errors = new string[] { "Kitap stoku başarıyla silindi." }
                };
            }
            catch (Exception ex)
            {
                // Kitap stok silme işlemi sırasında bir hata oluşursa
                return new DeleteBookStockCommandResponse
                {
                    StatusCode = 500,
                    Success = false,
                    Errors = new string[] { $"Bir hata oluştu: {ex.Message}" }
                };
            }
        }
    }
}

