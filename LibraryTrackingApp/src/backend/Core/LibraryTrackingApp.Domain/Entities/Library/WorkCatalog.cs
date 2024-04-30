namespace LibraryTrackingApp.Domain.Entities.Library;

/// <summary>
/// Katalogdaki bir eseri temsil eder.
/// </summary>
public class WorkCatalog : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid GenreId { get; set; } // Eserin türü
    public Guid EditionId { get; set; } // Eserin türü
    
    public Guid PublisherId { get; set; } // Yayımcının kimliği
    public Guid AuthorId { get; set; } // Yazarın kimliği
    public Guid LibraryBranchId { get; set; } // Eserin bulunduğu kütüphane şubesinin kimliği
    public Guid BookStockId { get; set; } // Eserin stok kimliği

    public string Title { get; set; } // Eserin başlığı
    public string ISBN { get; set; } // Uluslararası Standart Kitap Numarası
    public string CoverImageUrl { get; set; } // Kapak resminin URL'si
    public int PageCount { get; set; } // Sayfa sayısı



    public string? AudioFilePath { get; set; } // Ses dosyasının yolunu saklar
    public string? FilePath { get; set; } // Dosyanın yolunu saklar

    public DateTime PublicationDate { get; set; } // Yayımlanma tarihi
    public DateTime OriginalPublicationDate { get; set; } // Orijinal yayımlanma tarihi
    public WorkStatus BookStatus { get; set; } // Eserin durumu
    public WorkFormat BookFormat { get; set; } // Eserin formatı
    public string? WorkLanguage { get; set; } // Eserin dili
    public bool IsFeatured { get; set; } // Öne çıkarılmış mı?


    public string? Summary { get; set; } // Özet bilgisi
    public bool IsBorrowable { get; set; } // Ödünç verilebilir mi?
    public string? Translator { get; set; } // Çevirmen
    public string? Editor { get; set; } // Editör

    public bool HasTagPrinted { get; set; } // Etiket basıldı mı?


    public WorkGenre Genre { get; set; } // Eserin türü
    public WorkPublisher Publisher { get; set; } // Yayımcı bilgisi

    public LibraryBranch LibraryBranch { get; set; } // Eserin bulunduğu kütüphane şubesi
    public ICollection<WorkTag> Tags { get; set; } // Baskılar
    public ICollection<Edition> Editions { get; set; } // Etiketler
    public ICollection<Author> Authors { get; set; } // Yazarlar
    public ICollection<BookStockOLD> BookStocks { get; set; } // Stoklar
    public ICollection<BorrowLend> Borrows { get; set; } // Ödünç alınma/verilme kayıtları
    public ICollection<WorkInventory> BookInventories { get; set; } // Eser envanterleri
}
