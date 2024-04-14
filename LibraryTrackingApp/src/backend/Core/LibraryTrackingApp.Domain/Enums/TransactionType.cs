namespace LibraryTrackingApp.Domain.Enums;

[Flags]
public enum TransactionType
{
    None = 0,
    BookBorrow = 1 << 0,         // Kitap ödünç alma
    BookReturn = 1 << 1,         // Kitap iade
    BookReservation = 1 << 2,    // Kitap rezervasyon
    BookAddition = 1 << 3,       // Kitap ekleme
    BookRemoval = 1 << 4         // Kitap kaldırma
}

