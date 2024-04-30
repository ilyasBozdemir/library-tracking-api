namespace LibraryTrackingApp.Application.DataTransferObjects;

public record CreateBookDto : BaseAuditableDTO<Guid>
{
    public Guid AuthorId { get; init; } // Yazar ID
    public Guid GenreId { get; init; } // Tür ID
    public Guid LibraryBranchId { get; init; } // Kütüphane Şube ID
    public string Title { get; init; } // Başlık
    public string ISBN { get; init; } // ISBN
    public int PageCount { get; init; } // Sayfa Sayısı

    public Guid PublisherId { get; init; } // Yayıncı ID
    public DateTime PublicationDate { get; init; } // Yayın Tarihi
    public DateTime OriginalPublicationDate { get; init; } // Orijinal Yayın Tarihi
    public WorkStatus Status { get; init; } // Kitap Durumu
    public WorkFormat Format { get; init; } // Kitap Formatı
    public string Language { get; init; } // Kitap Dili
    public bool IsDamaged { get; init; } // Hasar Durumu
    public string Description { get; init; } // Açıklama
    public string CoverImageUrl { get; init; } // Kapak Resmi URL'i
    public bool IsFeatured { get; init; } // Öne Çıkarılmış mı?
}
