using Microsoft.AspNetCore.JsonPatch.Operations;

namespace LibraryTrackingApp.Application.Features.BookStocks.Events;

public class StockOperationEventHandler : INotificationHandler<StockOperationEvent>
{
    public async Task Handle(StockOperationEvent notification, CancellationToken cancellationToken)
    {
        if (!notification.IsSuccessful)
        {
            switch (notification.OperationType)
            {
                case StockOperationType.Increase:
                    Console.WriteLine($"");
                    break;
                case StockOperationType.Decrease:
                    Console.WriteLine($"");
                    break;
                default:
                    Console.WriteLine("Tanımsız bir işlem türü alındı.");
                    break;
            }
        }
        else
        {
            Console.WriteLine(
                $"Şununla kitap için stok işlemi başarısız oldu: ID: {notification.BookId}. Quantity: {notification.Quantity}. Operation: {notification.OperationType}"
            );
            foreach (var error in notification.Errors)
            {
                Console.WriteLine($"Error: {error}");
            }
        }
    }
}
