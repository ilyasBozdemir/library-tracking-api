using System.Text.Json.Serialization;

namespace LibraryTrackingApp.Application.Features.Commands.Book.CreateBook;

public class CreateBookCommandRequest : IRequest<CreateBookCommandResponse>
{
    public string Title { get; init; } // Kitap Başlığı
    public Guid AuthorId { get; init; } // Yazar ID
    public string ISBN { get; init; } // ISBN
    public int PageCount { get; init; } // Sayfa Sayısı
    public DateTime PublicationDate { get; init; } // Yayın Tarihi

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public BookStatus Status { get; init; } = BookStatus.Available; // Kitap Durumu
    public Guid GenreId { get; init; } // Tür Id'si
    public Guid PublisherId { get; init; } // Yayıncı Id'si
    public Guid LibraryBranchId { get; init; } // Kütüphane Şube Id'si
    public Guid? BookStockBranchId { get; init; } // Kitap Stok Şubesi Id'si
    public string Description { get; init; } // Açıklama
    public string CoverImageUrl { get; init; } // Kapak Resmi URL'i
    public DateTime OriginalPublicationDate { get; init; } // Orijinal Yayın Tarihi

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public BookFormat Format { get; init; } // Kitap Formatı

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public BookLanguage Language { get; init; } // Kitap Dili
    public bool IsFeatured { get; init; } // Öne Çıkarılmış mı?
}