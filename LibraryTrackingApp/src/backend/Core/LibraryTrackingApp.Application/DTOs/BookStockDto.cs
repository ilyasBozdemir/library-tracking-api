namespace LibraryTrackingApp.Application.DTOs;

public record BookStockDto : BaseAuditableDTO<Guid>
{
    public Guid Id { get; init; } // Kitap Stok ID
    public Guid BookId { get; init; } // Kitap ID
    public int Quantity { get; init; } // Stok Miktarı
}
