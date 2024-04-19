namespace LibraryTrackingApp.Domain.Entities.Library;

public class FavoriteList : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid MemberId { get; set; }
    public ICollection<Book> FavoriteBooks { get; set; }
}

