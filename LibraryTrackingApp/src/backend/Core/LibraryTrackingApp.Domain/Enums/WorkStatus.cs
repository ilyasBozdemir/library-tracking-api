namespace LibraryTrackingApp.Domain.Enums;

/// <summary>
/// Bir Eser durumunu belirtir.
/// </summary>
[Flags]
public enum WorkStatus
{
    /// <summary>
    /// Eser aktif durumda.
    /// </summary>
    Active = 1 << 0, // 1

    /// <summary>
    /// Eser pasif durumda.
    /// </summary>
    Inactive = 1 << 1, // 2

    /// <summary>
    /// Eser hasarlı durumda.
    /// </summary>
    Damaged = 1 << 2, // 4

    /// <summary>
    /// Eser kayıp durumda.
    /// </summary>
    Lost = 1 << 3, // 8
}
