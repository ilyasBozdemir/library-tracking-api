namespace LibraryTrackingApp.Domain.Enums;

/// <summary>
/// Bir kitabın formatını belirtir.
/// </summary>
[Flags]
public enum BookFormat
{
    /// <summary>
    /// Kitap basılı formatta.
    /// </summary>
    PrintedBook = 1 << 0,

    /// <summary>
    /// Kitap elektronik formatta.
    /// </summary>
    EBook = 1 << 1,

    /// <summary>
    /// Kitap sesli formatta.
    /// </summary>
    AudioBook = 1 << 2
}

