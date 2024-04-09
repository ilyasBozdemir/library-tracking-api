using LibraryTrackingApp.Domain.Enums;

namespace LibraryTrackingApp.Application.DTOs;

public record CreateBookDto : BaseAuditableDTO
{
    public string Title { get; init; } // Başlık
    public string Author { get; init; } // Yazar
    public string ISBN { get; init; } // ISBN
    public int PageCount { get; init; } // Sayfa Sayısı
    public string Publisher { get; init; } // Yayıncı
    public DateTime PublicationDate { get; init; } // Yayın Tarihi
    public BookStatus Status { get; init; } // Kitap Durumu
    public bool IsDamaged { get; init; } // Hasar Durumu
}
