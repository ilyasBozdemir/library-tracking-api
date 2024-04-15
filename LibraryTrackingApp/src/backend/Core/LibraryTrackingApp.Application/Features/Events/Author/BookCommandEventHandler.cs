using LibraryTrackingApp.Application.Features.Events.Book;

namespace LibraryTrackingApp.Application.Features.Events.Author;

public class AuthorCommandEventHandler : INotificationHandler<AuthorCommandEvent>
{
    public AuthorCommandEventHandler()
    {
        // Constructor gerekli bir işlem yapmıyor, dolayısıyla içini boş bırakabiliriz.
    }

    public async Task Handle(AuthorCommandEvent notification, CancellationToken cancellationToken)
    {
        switch (notification.RequestNotificationType)
        {
            case RequestNotificationType.Create:
                Console.WriteLine($"Yeni bir Yazar oluşturuldu. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Update:

                Console.WriteLine($"Yazar güncellendi. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Delete:
                Console.WriteLine($"Yazar silindi. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Get:
                Console.WriteLine($"Yazar bilgileri alındı. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.GetAll:
                Console.WriteLine("Tüm Yazar bilgileri alındı.");
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

