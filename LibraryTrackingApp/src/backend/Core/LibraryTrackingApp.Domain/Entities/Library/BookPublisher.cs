namespace LibraryTrackingApp.Domain.Entities.Library;

using System;

public class BookPublisher : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; } // Yayınevi ID'si
    public string Name { get; set; } // Yayınevi adı
    public string Website { get; set; }
    public string Address { get; set; } // Yayınevi adresi
    public string PhoneNumber { get; set; } // Yayınevi telefon numarası
    public string Email { get; set; } // Yayınevi e-posta adresi

    public ICollection<Book> Books { get; set; }
}
