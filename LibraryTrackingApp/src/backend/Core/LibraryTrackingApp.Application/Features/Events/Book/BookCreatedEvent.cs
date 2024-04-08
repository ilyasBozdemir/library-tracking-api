using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookCreatedEvent : BaseEvent
{
    public BookDTO BookDTO { get; set; }
}
