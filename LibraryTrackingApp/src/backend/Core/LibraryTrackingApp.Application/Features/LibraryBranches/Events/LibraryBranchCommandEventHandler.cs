namespace LibraryTrackingApp.Application.Features.LibraryBranches.Events;

public class LibraryBranchCommandEventHandler : INotificationHandler<LibraryBranchCommandEvent>
{
    public LibraryBranchCommandEventHandler()
    {
        
    }

    public async Task Handle(LibraryBranchCommandEvent notification, CancellationToken cancellationToken)
    {
        switch (notification.RequestNotificationType)
        {
            case RequestNotificationType.Create:
                Console.WriteLine($"Yeni bir Şube oluşturuldu. Şube ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Update:

                Console.WriteLine($"Şube güncellendi. Şube ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Delete:
                Console.WriteLine($"Şube silindi. Şube ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.Get:
                Console.WriteLine($"Şube bilgileri alındı. Şube ID: {notification.AuthorId}");
                break;
            case RequestNotificationType.GetAll:
                Console.WriteLine("Tüm Şube bilgileri alındı.");
                break;
            default:
                // Tanımsız bir işlem türü gelirse buraya düşer
                // Bu durumu uygun şekilde işlemek gerekir
                Console.WriteLine("Tanımsız bir işlem türü alındı.");
                break;
        }

    }
}

