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
    /// Gecikmeli iade.
    /// </summary>
    DelayedReturn = 1 << 3,

    /// <summary>
    /// Süresi doldu.
    /// </summary>
    Expired = 1 << 4,// ödünç kitap sonucları için , bgservices ile duedate ile datetime.now kontrol ettirip o an expired olarak işaretlenmesi de yapılabliir 


    /// <summary>
    /// İptal edildi.
    /// </summary>
    Cancelled = 1 << 5,

    /// <summary>
    /// Kayıp.
    /// </summary>
    Losted = 1 << 6,

    /// <summary>
    /// Hasarlı.
    /// </summary>
    Damaged = 1 << 7,

    /// <summary>
    /// Askıya alındı.
    /// </summary>
    OnHold = 1 << 8
}
