using LibraryTrackingApp.Application.Features.BookInventories.Commands.Responses;
using System.Text.Json.Serialization;

namespace LibraryTrackingApp.Application.Features.BookInventories.Commands.Requests;

public class UpdateBookCommandRequest : IRequest<UpdateBookCommandResponse>
{
    public Guid Id { get; set; } // Güncellenecek kitabın ID'si

    public string Title { get; set; } // Yeni başlık
    public string Author { get; set; } // Yeni yazar
    public string ISBN { get; set; } // Yeni ISBN
    public int PageCount { get; set; } // Yeni sayfa sayısı
    public string Publisher { get; set; } // Yeni yayıncı
    public string Summary { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime PublicationDate { get; set; } // Yeni yayın tarihi
    public DateTime OriginalPublicationDate { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WorkStatus BookStatus { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WorkFormat BookFormat { get; set; }

    public string BookLanguage { get; set; }
    public bool IsFeatured { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WorkStatus Status { get; set; } // Yeni kitap durumu

    public Guid GenreId { get; set; }
    public Guid PublisherId { get; set; }
    public Guid AuthorId { get; set; }
    public Guid LibraryBranchId { get; set; }
    public Guid BookStockId { get; set; }
    public Guid BorrowId { get; set; }
    public Guid TagId { get; set; }


}
