namespace LibraryTrackingApp.Application.Features.Books.Events;

public class BookCommandEventHandler : INotificationHandler<BookCommandEvent>
{
    public BookCommandEventHandler()
    {
        // Constructor gerekli bir işlem yapmıyor, dolayısıyla içini boş bırakabiliriz.
    }

    public async Task Handle(BookCommandEvent notification, CancellationToken cancellationToken)
    {
        switch (notification.RequestNotificationType)
        {
            case RequestNotificationType.Created:
                Console.WriteLine($"Yeni bir kitap oluşturuldu. Kitap ID: {notification.BookId}");
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

        // İşlem başarılıysa loglama, bildirim gönderme gibi işlemler yapılabilir
    }
}

