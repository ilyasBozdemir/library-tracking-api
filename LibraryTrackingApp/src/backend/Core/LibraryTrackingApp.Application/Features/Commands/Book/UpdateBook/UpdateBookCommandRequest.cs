using LibraryTrackingApp.Domain.Enums;
using MediatR;

namespace LibraryTrackingApp.Application.Features.Commands.Book.UpdateBook;

public class UpdateBookCommandRequest : IRequest<UpdateBookCommandResponse>
{
    public Guid Id { get; set; } // Güncellenecek kitabın ID'si

    public string Title { get; set; } // Yeni başlık
    public string Author { get; set; } // Yeni yazar
    public string ISBN { get; set; } // Yeni ISBN
    public int PageCount { get; set; } // Yeni sayfa sayısı
    public string Publisher { get; set; } // Yeni yayıncı
    public DateTime PublicationDate { get; set; } // Yeni yayın tarihi
    public BookStatus Status { get; set; } // Yeni kitap durumu
    public bool IsDamaged { get; set; } // Yeni hasar durumu
}
