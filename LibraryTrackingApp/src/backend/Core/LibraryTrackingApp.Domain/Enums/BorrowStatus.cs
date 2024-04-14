namespace LibraryTrackingApp.Domain.Enums;
/// <summary>
/// Ödünç durumunu belirten bir enum.
/// </summary>
[Flags]
public enum BorrowStatus
{
    /// <summary>
    /// İşlem bekliyor.
    /// </summary>
    Pending = 1 << 0,    // 1

    /// <summary>
    /// Ödünç alındı.
    /// </summary>
    Borrowed = 1 << 1,   // 2

    /// <summary>
    /// İade edildi.
    /// </summary>
    Completed = 1 << 2,  // 4

    /// <summary>
    /// İade edildi.
    /// </summary>
    Returned = 1 << 3,   // 8

    /// <summary>
    /// Süresi doldu.
    /// </summary>
    Expired = 1 << 4,    // 16

    /// <summary>
    /// İptal edildi.
    /// </summary>
    Cancelled = 1 << 5,  // 32

    /// <summary>
    /// Kayıp.
    /// </summary>
    Lost = 1 << 6,       // 64

    /// <summary>
    /// Hasarlı.
    /// </summary>
    Damaged = 1 << 7,    // 128

    /// <summary>
    /// Askıya alındı.
    /// </summary>
    OnHold = 1 << 8      // 256
}
