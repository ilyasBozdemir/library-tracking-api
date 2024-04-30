namespace LibraryTrackingApp.Domain.Entities.Library;


//bunlar bir sonraki güncellemede veritabanına migrate edilcektir. raf ve kitap bölmesi dataları 
public class Shelf : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid LibraryBranchId { get; set; }
    public string Name { get; set; }

    public LibraryBranch LibraryBranch { get; set; }
    public ICollection<WorkCompartment> Compartments { get; set; }
}