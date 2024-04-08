namespace LibraryTrackingApp.Application.DTOs;

public record BookStockDto
{
    public Guid Id { get; init; } // Kitap Stok ID
    public Guid BookId { get; init; } // Kitap ID
    public int Quantity { get; init; } // Stok Miktarı
}
