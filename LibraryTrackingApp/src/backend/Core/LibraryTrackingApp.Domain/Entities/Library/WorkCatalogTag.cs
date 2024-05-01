namespace LibraryTrackingApp.Domain.Entities.Library;

public class WorkCatalogTag
{
    public Guid TagId { get; set; }
    public WorkTag Tag { get; set; }

    public Guid WorkCatalogId { get; set; }
    public WorkCatalog WorkCatalog { get; set; }
}
