using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Events;

public class BookGenreEvent
    : BaseEvent
{
    public Guid BookGenreId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
