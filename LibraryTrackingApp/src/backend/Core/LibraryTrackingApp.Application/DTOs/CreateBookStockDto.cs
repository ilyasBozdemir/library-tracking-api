namespace LibraryTrackingApp.Application.DTOs;

public record CreateBookStockDto : BaseAuditableDTO<Guid>
{
    public Guid BookId { get; init; } // Kitap ID
    public int Quantity { get; init; } // Stok Miktarı
}
