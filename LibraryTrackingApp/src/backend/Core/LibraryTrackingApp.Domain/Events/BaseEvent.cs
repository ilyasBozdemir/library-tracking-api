using MediatR;
namespace LibraryTrackingApp.Domain.Events;
public abstract class BaseEvent : INotification
{
    public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;
}

