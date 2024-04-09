using LibraryTrackingApp.Application.Features.Events.Book;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.BookStock.CreateBookStock;

public class CreateBookStockCommandHandler : IRequestHandler<CreateBookStockCommandRequest, CreateBookStockCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;

    public CreateBookStockCommandHandler(IUnitOfWork<Guid> unitOfWork, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }
    public async Task<CreateBookStockCommandResponse> Handle(CreateBookStockCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var existingBook = await _unitOfWork.GetReadRepository<Domain.Entities.Library.Book>()
                .ExistsAsync(b => b.Id == request.BookId);

            if (!existingBook)
                return new CreateBookStockCommandResponse
                {
                    StatusCode = 404,
                    Success = false,
                    Errors = new string[] { "Verilen ID'ye ait kitap bulunamadı." }
                };
            else
            {
                var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.BookStock>();
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.BookStock>();

                var existingBookStock = await readRepository.GetSingleAsync(s => s.BookId == request.BookId);

                if (existingBookStock != null)
                {
                    existingBookStock.Quantity += request.Quantity;
                    await writeRepository.UpdateAsync(existingBookStock);
                }
                else
                {
                    var newBookStock = new Domain.Entities.Library.BookStock()
                    {
                        BookId = request.BookId,
                        Quantity = request.Quantity,
                    };
                    await writeRepository.AddAsync(newBookStock);
                }
                return new CreateBookStockCommandResponse
                {
                    StatusCode = 200,
                    Success = true,
                    Errors = new string[] { "Kitap Stok kaydı başarıyla güncellendi veya eklendi." }
                };
            }
        }
        catch (Exception ex)
        {
            return new CreateBookStockCommandResponse
            {
                StatusCode = 500,
                Success = false,
                Errors = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}