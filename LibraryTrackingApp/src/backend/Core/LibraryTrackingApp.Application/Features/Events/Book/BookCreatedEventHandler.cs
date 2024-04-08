using Microsoft.Extensions.Logging;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookCreatedEventHandler : INotificationHandler<BookCreatedEvent>
{
    public BookCreatedEventHandler()
    {
            
    }

    public async Task Handle(BookCreatedEvent notification, CancellationToken cancellationToken)
    {
        try
        {
            Console.WriteLine("Yeni kitap oluşturuldu. Kitap ID: {Title}", notification.BookDTO.Title);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kitap oluşturulurken bir hata oluştu. {ex.Message}");
        }
    }
}
