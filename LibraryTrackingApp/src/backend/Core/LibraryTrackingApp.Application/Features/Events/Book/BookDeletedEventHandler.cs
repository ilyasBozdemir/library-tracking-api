using MediatR;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookDeletedEventHandler: INotificationHandler<BookDeletedEvent>
{
    public async Task Handle(BookDeletedEvent notification, CancellationToken cancellationToken)
    {
       
    }
}
