using MediatR;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookUpdatedEventHandler : INotificationHandler<BookUpdatedEvent>
{
    public async Task Handle(BookUpdatedEvent notification, CancellationToken cancellationToken)
    {
       
    }
}
