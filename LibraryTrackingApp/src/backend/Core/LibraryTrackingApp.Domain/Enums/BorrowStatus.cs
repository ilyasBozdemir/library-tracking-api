namespace LibraryTrackingApp.Domain.Enums;

[Flags]
public enum BorrowStatus
{
    Pending = 1 << 0,    // İşlem bekliyor - 1
    Borrowed = 1 << 1,   // Ödünç alındı - 2
    Completed = 1 << 2,  // İade edildi - 4
    Returned = 1 << 3,   // İade edildi - 8
    Expired = 1 << 4,    // Süresi doldu - 16
    Cancelled = 1 << 5,  // İptal edildi - 32
    Lost = 1 << 6,       // Kayıp - 64
    Damaged = 1 << 7,    // Hasarlı - 128
    OnHold = 1 << 8      // Askıya alındı - 256
}