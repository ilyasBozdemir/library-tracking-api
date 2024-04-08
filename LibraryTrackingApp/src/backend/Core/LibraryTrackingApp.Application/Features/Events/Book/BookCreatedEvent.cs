using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookCreatedEvent : BaseEvent
{
    public Guid BookId { get; set; }
}
