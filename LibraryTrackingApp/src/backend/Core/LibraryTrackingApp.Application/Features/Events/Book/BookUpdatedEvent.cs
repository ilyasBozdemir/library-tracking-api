using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookUpdatedEvent: BaseEvent
{
    public Guid BookId { get; set; }
}
