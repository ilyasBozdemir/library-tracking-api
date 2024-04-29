namespace LibraryTrackingApp.Domain.Entities.Library;


//bunlar bir sonraki güncellemede veritabanına migrate edilcektir. raf ve kitap bölmesi dataları 
public class Shelf : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<BookCompartment> Compartments { get; set; }
}