using LibraryTrackingApp.Domain.Enums;
using MediatR;

namespace LibraryTrackingApp.Application.Features.Commands.Book.CreateBook;

public class CreateBookCommandRequest : IRequest<CreateBookCommandResponse>
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
