using MediatR;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookCreatedEventHandler : INotificationHandler<BookCreatedEvent>
{
    public async Task Handle(BookCreatedEvent notification, CancellationToken cancellationToken)
    {
        
    }
}
