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
    Active = 1 << 0, // 1

    /// <summary>
    /// Kitap pasif durumda.
    /// </summary>
    Inactive = 1 << 1, // 2
}
