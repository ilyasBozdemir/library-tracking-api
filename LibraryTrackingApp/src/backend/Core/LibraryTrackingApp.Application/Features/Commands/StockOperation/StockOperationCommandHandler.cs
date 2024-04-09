using LibraryTrackingApp.Application.Features.Events.BookStock;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.StockOperation;

public class StockOperationCommandHandler
    : IRequestHandler<StockOperationCommandRequest, StockOperationCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;

    public StockOperationCommandHandler(IUnitOfWork<Guid> unitOfWork, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task<StockOperationCommandResponse> Handle(
        StockOperationCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var existingBook = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Book>()
                .ExistsAsync(b => b.Id == request.BookId);
            if (!existingBook)
            {
                return new()
                {
                    StatusCode = 404,
                    Success = false,
                    Errors = new string[] { "Verilen ID'ye ait kitap bulunamadı." }
                };
            }
            else
            {
                var readRepository =
                    _unitOfWork.GetReadRepository<Domain.Entities.Library.BookStock>();
                var writeRepository =
                    _unitOfWork.GetWriteRepository<Domain.Entities.Library.BookStock>();

                var existingBookStock = await readRepository.GetSingleAsync(
                    s => s.BookId == request.BookId
                );
                if (existingBookStock != null)
                {
                    switch (request.OperationType)
                    {
                        case StockOperationType.Increase:
                            existingBookStock.Quantity += request.Quantity;
                            break;
                        case StockOperationType.Decrease:
                            if (existingBookStock.Quantity < request.Quantity)
                            {
                                return new()
                                {
                                    StatusCode = 400,
                                    Success = false,
                                    Errors = new string[]
                                    {
                                        "Stok miktarı talep edilen miktardan az."
                                    }
                                };
                            }
                            existingBookStock.Quantity -= request.Quantity;
                            break;
                        default:
                            return new()
                            {
                                StatusCode = 400,
                                Success = false,
                                Errors = new string[]
                                {
                                    "Bilinmeyen işlem türü. Lütfen geçerli bir işlem türü belirtin."
                                }
                            };
                            break;
                    }

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

                return new()
                {
                    StatusCode = 200,
                    Success = true,
                    Errors = new string[] { "Kitap Stok kaydı başarıyla güncellendi." }
                };
            }
        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                Errors = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
