namespace LibraryTrackingApp.Domain.Enums;

/// <summary>
/// Ödünç durumunu belirten bir enum.
/// </summary>
[Flags]
public enum BorrowStatus
{
    /// <summary>
    /// Ödünç alındı.
    /// </summary>
    Borrowed = 1 << 1,

    /// <summary>
    /// İade edildi.
    /// </summary>
    Returned = 1 << 2,

    /// <summary>
    /// Süresi doldu.
    /// </summary>
    Expired = 1 << 3,

    /// <summary>
    /// İptal edildi.
    /// </summary>
    Cancelled = 1 << 4,

    /// <summary>
    /// Kayıp.
    /// </summary>
    Losted = 1 << 5,

    /// <summary>
    /// Hasarlı.
    /// </summary>
    Damaged = 1 << 6,

    /// <summary>
    /// Askıya alındı.
    /// </summary>
    OnHold = 1 << 7
}
