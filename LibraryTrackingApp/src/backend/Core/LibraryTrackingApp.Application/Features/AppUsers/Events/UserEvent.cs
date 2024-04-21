using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.AppUsers.Events;

public class UserEvent : BaseEvent
{
    public Guid UserId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
