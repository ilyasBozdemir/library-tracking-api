namespace LibraryTrackingApp.Domain.Entities.Library;

public class AuthorWorkCatalog
{
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }

    public Guid WorkCatalogId { get; set; }
    public WorkCatalog WorkCatalog { get; set; }
}
