using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.Events.Author;

public class AuthorCommandEvent : BaseEvent
{
    public Guid AuthorId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
