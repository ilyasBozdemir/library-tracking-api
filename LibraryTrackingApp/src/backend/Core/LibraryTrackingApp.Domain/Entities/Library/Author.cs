namespace LibraryTrackingApp.Domain.Entities.Library;

/*   
    public DateTime BirthDate { get; set; }
   
   unix seconds olarak saklanacaktır sonra ki güncellemede.
 */

public class Author : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }
    public string Website { get; set; }


    public ICollection<WorkCatalog> Books { get; set; }
}
