namespace LibraryTrackingApp.Domain.Entities.Library;

public class Shelf : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid LibraryBranchId { get; set; }
    public string Name { get; set; }

    public LibraryBranch LibraryBranch { get; set; }
    public ICollection<WorkCompartment> Compartments { get; set; }
}