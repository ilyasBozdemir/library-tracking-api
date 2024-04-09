namespace LibraryTrackingApp.Application.DTOs;

public record CreateBookStockDto : BaseAuditableDTO
{
    public Guid BookId { get; init; } // Kitap ID
    public int Quantity { get; init; } // Stok Miktarı
}
