using MediatR;

namespace LibraryTrackingApp.Domain.Events;

public abstract class BaseEvent : INotification
{
    public string EntityId { get; set; }
    public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;
    public bool IsSuccessful { get; set; }
    public string[] Errors { get; set; }
}
