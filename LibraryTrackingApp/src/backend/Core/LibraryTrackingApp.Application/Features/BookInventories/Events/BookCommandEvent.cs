using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.BookInventories.Events;

public class BookCommandEvent : BaseEvent
{
    public Guid BookId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
