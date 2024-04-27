namespace LibraryTrackingApp.Application.DataTransferObjects;

public record CreateBookPublisherDTO : BaseAuditableDTO<Guid>
{
    public string Name { get; set; } // Yayınevi adı
    public string Website { get; set; }
    public string Address { get; set; } // Yayınevi adresi
    public string PhoneNumber { get; set; } // Yayınevi telefon numarası
    public string Email { get; set; } // Yayınevi e-posta adresi
}
