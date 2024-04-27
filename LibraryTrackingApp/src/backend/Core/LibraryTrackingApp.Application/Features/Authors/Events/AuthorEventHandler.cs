using LibraryTrackingApp.Application.Features.AppUsers.Events;

namespace LibraryTrackingApp.Application.Features.Authors.Events;

public class AuthorEventHandler : INotificationHandler<AuthorEvent>
{
    public AuthorEventHandler()
    {
        // Constructor gerekli bir işlem yapmıyor, dolayısıyla içini boş bırakabiliriz.
    }

    public async Task Handle(AuthorEvent notification, CancellationToken cancellationToken)
    {
        switch (notification.RequestNotificationType)
        {
            case RequestNotificationType.Created:
                Console.WriteLine($"Yeni bir Yazar oluşturuldu. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Updated:

                Console.WriteLine($"Yazar güncellendi. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Deleted:
                Console.WriteLine($"Yazar silindi. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.FetchedSingle:
                Console.WriteLine($"Yazar bilgileri alındı. Yazar ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.FetchedAll:
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

