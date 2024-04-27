namespace LibraryTrackingApp.Application.Features.BookPublishers.Events;

public class BookPublisherEventHandler : INotificationHandler<BookPublisherEvent>
{
    public BookPublisherEventHandler()
    {
        // Constructor gerekli bir işlem yapmıyor, dolayısıyla içini boş bırakabiliriz.
    }

    public async Task Handle(BookPublisherEvent notification, CancellationToken cancellationToken)
    {
        switch (notification.RequestNotificationType)
        {
            case RequestNotificationType.Created:
                Console.WriteLine(
                    $"Yeni bir yayınevi oluşturuldu. Yayınevi ID: {notification.BookPublisherId}"
                );
                break;
            case RequestNotificationType.Updated:

                Console.WriteLine(
                    $"Yayınevi güncellendi. Yayınevi ID: {notification.BookPublisherId}"
                );
                break;
            case RequestNotificationType.Deleted:
                Console.WriteLine($"Yayınevi silindi. Yayınevi ID: {notification.BookPublisherId}");
                break;
            case RequestNotificationType.FetchedSingle:
                Console.WriteLine(
                    $"Yayınevi bilgileri alındı. Yayınevi ID: {notification.BookPublisherId}"
                );
                break;
            case RequestNotificationType.FetchedAll:
                Console.WriteLine("Tüm Yayınevi bilgileri alındı.");
                break;
            default:
                // Tanımsız bir işlem türü gelirse buraya düşer
                Console.WriteLine("Tanımsız bir işlem türü alındı.");
                break;
        }
    }
}
