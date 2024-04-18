namespace LibraryTrackingApp.Application.DTOs;

public record BookDTO: BaseAuditableDTO<Guid>
{
    public Guid Id { get; init; } // Kitap ID
    public Guid AuthorId { get; init; } // Yazar ID
    public Guid GenreId { get; init; } // Tür ID
    public Guid PublisherId { get; init; } // Yayıncı ID
    public Guid LibraryBranchId { get; init; } // Kütüphane Şube ID
    public string Title { get; init; } // Başlık
    public string ISBN { get; init; } // ISBN
    public int PageCount { get; init; } // Sayfa Sayısı

    public DateTime PublicationDate { get; init; } // Yayın Tarihi
    public DateTime OriginalPublicationDate { get; init; } // Orijinal Yayın Tarihi
    public BookStatus Status { get; init; } // Kitap Durumu
    public BookFormat Format { get; init; } // Kitap Formatı
    public BookLanguage Language { get; init; } // Kitap Dili
    public bool IsDamaged { get; init; } // Hasar Durumu
    public string Description { get; init; } // Açıklama
    public string CoverImageUrl { get; init; } // Kapak Resmi URL'i
    public bool IsFeatured { get; init; } // Öne Çıkarılmış mı?
}