namespace LibraryTrackingApp.Application.Features.Books.Events;

public class BookCommandEventHandler : INotificationHandler<BookCommandEvent>
{
    public BookCommandEventHandler() { }

    public async Task Handle(BookCommandEvent notification, CancellationToken cancellationToken)
    {
        if (!notification.IsSuccessful)
        {
            switch (notification.RequestNotificationType)
            {
                case RequestNotificationType.Created:
                    Console.WriteLine($"Yeni bir kitap oluşturulamadı.");
                    break;
                case RequestNotificationType.Updated:
                    Console.WriteLine($"kitap güncellenemedi.");
                    break;
                case RequestNotificationType.Deleted:
                    Console.WriteLine($"kitap silinemedi.");
                    break;
                case RequestNotificationType.FetchedSingle:
                    Console.WriteLine($"kitap bilgileri alınamadı.");
                    break;
                case RequestNotificationType.FetchedAll:
                    Console.WriteLine("Tüm kitap bilgileri alınamadı.");
                    break;
                default:
                    Console.WriteLine("Tanımsız bir işlem türü alındı.");
                    break;
            }
        }
        else
        {
            switch (notification.RequestNotificationType)
            {
                case RequestNotificationType.Created:
                    Console.WriteLine(
                        $"Yeni bir kitap oluşturuldu. Kitap ID: {notification.BookId}"
                    );
                    break;
                case RequestNotificationType.Updated:

                    Console.WriteLine($"Kitap güncellendi. Kitap ID: {notification.BookId}");
                    break;
                case RequestNotificationType.Deleted:
                    Console.WriteLine($"Kitap silindi. Kitap ID: {notification.BookId}");
                    break;
                case RequestNotificationType.FetchedSingle:
                    Console.WriteLine($"Kitap bilgileri alındı. Kitap ID: {notification.BookId}");
                    break;
                case RequestNotificationType.FetchedAll:
                    Console.WriteLine("Tüm kitap bilgileri alındı.");
                    break;
                default:
                    // Tanımsız bir işlem türü gelirse buraya düşer
                    // Bu durumu uygun şekilde işlemek gerekir
                    Console.WriteLine("Tanımsız bir işlem türü alındı.");
                    break;
            }
        }
    }
}
