namespace LibraryTrackingApp.Application.Features.BorrowLend.Events;


public class BorrowLendEventHandler : INotificationHandler<BorrowLendEvent>
{
    public async Task Handle(BorrowLendEvent notification, CancellationToken cancellationToken)
    {
        if (!notification.IsSuccessful)
        {
            switch (notification.BorrowLendType)
            {
                case BorrowLendType.Given:
                    Console.WriteLine($"kitap verilemedi.");
                    break;
                case BorrowLendType.Taken:
                    Console.WriteLine($"kitap alınamadı.");
                    break;
                case BorrowLendType.FetchedSingle:
                    Console.WriteLine($"kitap bilgileri alınamadı.");
                    break;
                case BorrowLendType.FetchedAll:
                    Console.WriteLine("Tüm kitap bilgileri alınamadı.");
                    break;
                default:
                    Console.WriteLine("Tanımsız bir işlem türü alındı.");
                    break;
            }
        }
        else
        {
            switch (notification.BorrowLendType)
            {
                case BorrowLendType.Given:
                    Console.WriteLine($"Yeni bir kitap verildi. Kitap ID: {notification.BookId}, Üye ID: {notification.MemberId}, Personel ID: {notification.LenderId}");
                    break;
                case BorrowLendType.Taken:
                    Console.WriteLine($"Yeni bir kitap alındı. Kitap ID: {notification.BookId}, Üye ID: {notification.MemberId}, Personel ID: {notification.LenderId}");
                    break;
                case BorrowLendType.FetchedSingle:
                    Console.WriteLine($"Kitap bilgileri alındı. Kitap ID: {notification.BookId}");
                    break;
                case BorrowLendType.FetchedAll:
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
