namespace LibraryTrackingApp.Domain.Entities.Library;

public class EditionWorkInventory
{
    public Guid EditionId { get; set; }
    public Edition Edition { get; set; }

    public Guid WorkInventoryId { get; set; }
    public WorkInventory WorkInventory { get; set; }
}
