namespace LibraryTrackingApp.Domain.Enums;

public enum TransactionType
{
    BookBorrow,         // Kitap ödünç alma
    BookReturn,         // Kitap iade
    BookReservation,    // Kitap rezervasyon
    BookAddition,       // Kitap ekleme
    BookRemoval         // Kitap kaldırma
}

