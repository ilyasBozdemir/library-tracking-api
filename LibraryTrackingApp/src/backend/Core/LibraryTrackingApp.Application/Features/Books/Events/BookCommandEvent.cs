using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.Books.Events;

public class BookCommandEvent : BaseEvent
{
    public Guid BookId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
