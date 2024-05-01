namespace LibraryTrackingApp.Application.Features.WorkGenres.Events;

public class BookGenreEventHandler : INotificationHandler<BookGenreEvent>
{
    public BookGenreEventHandler()
    {
        // Constructor gerekli bir işlem yapmıyor, dolayısıyla içini boş bırakabiliriz.
    }

    public async Task Handle(BookGenreEvent notification, CancellationToken cancellationToken)
    {
        if (!notification.IsSuccessful)
        {
            switch (notification.RequestNotificationType)
            {
                case RequestNotificationType.Created:
                    Console.WriteLine($"Yeni bir Tür oluşturulamadı.");
                    break;
                case RequestNotificationType.Updated:
                    Console.WriteLine($"Tür güncellenemedi.");
                    break;
                case RequestNotificationType.Deleted:
                    Console.WriteLine($"Tür silinemedi.");
                    break;
                case RequestNotificationType.FetchedSingle:
                    Console.WriteLine($"Tür bilgileri alınamadı.");
                    break;
                case RequestNotificationType.FetchedAll:
                    Console.WriteLine("Tüm Tür bilgileri alınamadı.");
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
                        $"Yeni bir Tür oluşturuldu. Tür ID: {notification.BookGenreId}"
                    );
                    break;
                case RequestNotificationType.Updated:

                    Console.WriteLine($"Tür güncellendi. Tür ID: {notification.BookGenreId}");
                    break;
                case RequestNotificationType.Deleted:
                    Console.WriteLine($"Tür silindi. Tür ID: {notification.BookGenreId}");
                    break;
                case RequestNotificationType.FetchedSingle:
                    Console.WriteLine($"Tür bilgileri alındı. Tür ID: {notification.BookGenreId}");
                    break;
                case RequestNotificationType.FetchedAll:
                    Console.WriteLine("Tüm Tür bilgileri alındı.");
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
