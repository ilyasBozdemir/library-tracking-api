namespace LibraryTrackingApp.Domain.Entities.Library;

public class ReadingList : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid MemberId { get; set; }
    public ICollection<WorkCatalog> Books { get; set; }
}
