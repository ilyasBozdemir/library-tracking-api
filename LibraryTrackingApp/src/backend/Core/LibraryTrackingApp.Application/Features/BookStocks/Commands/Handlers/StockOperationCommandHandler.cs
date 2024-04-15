using LibraryTrackingApp.Application.Features.BookStocks.Commands.Requests;
using LibraryTrackingApp.Application.Features.BookStocks.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using System.Net;

namespace LibraryTrackingApp.Application.Features.BookStocks.Commands.Handlers;

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
                    StateMessages = new string[] { "Verilen ID'ye ait kitap bulunamadı." }
                };
            }
            else
            {
                var readRepository =
                    _unitOfWork.GetReadRepository<Domain.Entities.Library.BookStock>();
                var writeRepository =
                    _unitOfWork.GetWriteRepository<Domain.Entities.Library.BookStock>();

                var existingBookStock = await readRepository.GetSingleAsync(
                    s => s.Id == request.BookId
                );
                if (existingBookStock != null)
                {
                    if (request.Quantity <= 0)
                    {
                        return new StockOperationCommandResponse
                        {
                            StatusCode = (int)HttpStatusCode.BadRequest,
                            Success = false,
                            StateMessages = new string[]
                            {
                                "Stok miktarı sıfırdan büyük olmalıdır."
                            }
                        };
                    }

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
                                    StateMessages = new string[]
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
                                StateMessages = new string[]
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
                        Id = request.BookId,
                        Quantity = request.Quantity,
                    };
                    await writeRepository.AddAsync(newBookStock);
                }

                return new()
                {
                    StatusCode = 200,
                    Success = true,
                    StateMessages = new string[] { "Kitap Stok kaydı başarıyla güncellendi." }
                };
            }
        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
