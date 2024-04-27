using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.BookGenres.Events;

public class BookGenreEvent
    : BaseEvent
{
    public Guid BookGenreId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
