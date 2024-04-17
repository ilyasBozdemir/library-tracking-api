using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Events;

public class LibraryBranchCommandEvent : BaseEvent
{
    public Guid AuthorId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
