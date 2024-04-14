namespace LibraryTrackingApp.Domain.Enums;

/// <summary>
/// Bir kitabın durumunu belirtir.
/// </summary>
[Flags]
public enum BookStatus
{
    /// <summary>
    /// Kitap aktif durumda.
    /// </summary>
    Active = 1 << 0,    // 1

    /// <summary>
    /// Kitap pasif durumda.
    /// </summary>
    Inactive = 1 << 1,  // 2

    /// <summary>
    /// Kitap mevcut durumda.
    /// </summary>
    Available = 1 << 2, // 4

    /// <summary>
    /// Kitap ödünç alınmış durumda.
    /// </summary>
    Borrowed = 1 << 3,  // 8

    /// <summary>
    /// Kitap rezerve edilmiş durumda.
    /// </summary>
    Reserved = 1 << 4,  // 16

    /// <summary>
    /// Kitap hasarlı durumda.
    /// </summary>
    Damaged = 1 << 5,   // 32

    /// <summary>
    /// Kitap kayıp durumda.
    /// </summary>
    Lost = 1 << 6       // 64
}