using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.Events.Book;

public class BookDeletedEvent : BaseEvent
{
    public BookDTO BookDTO { get; set; }
}
