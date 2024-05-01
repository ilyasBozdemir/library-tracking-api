namespace LibraryTrackingApp.Domain.Entities.Library;

public class WorkPublisher : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; } // Yayınevi ID'si
    public string Name { get; set; } // Yayınevi adı
    public string Website { get; set; }
    public string Address { get; set; } // Yayınevi adresi
    public string City { get; set; } // Yayınevinin bulunduğu şehir
    public string Country { get; set; } // Yayınevinin bulunduğu ülke
    public string PhoneNumber { get; set; } // Yayınevi telefon numarası
    public string Email { get; set; } // Yayınevi e-posta adresi




    public ICollection<WorkCatalog> WorkCatalogs { get; set; }
    public ICollection<Edition> Editions { get; set; }
}
