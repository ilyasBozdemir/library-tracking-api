
namespace LibraryTrackingApp.Application.Features.BookStocks.Events;

public class StockOperationEventHandler : INotificationHandler<StockOperationEvent>
{
    public async Task Handle(StockOperationEvent notification, CancellationToken cancellationToken)
    {
        if (notification.IsSuccessful)
        {
            Console.WriteLine($"Kitap için stok işlemi başarılı ID: {notification.BookId}. Quantity: {notification.Quantity}. Operation: {notification.OperationType}");
        }
        else
        {
            Console.WriteLine($"Şununla kitap için stok işlemi başarısız oldu: ID: {notification.BookId}. Quantity: {notification.Quantity}. Operation: {notification.OperationType}");
            foreach (var error in notification.Errors)
            {
                Console.WriteLine($"Error: {error}");
            }
        }
    }
}
