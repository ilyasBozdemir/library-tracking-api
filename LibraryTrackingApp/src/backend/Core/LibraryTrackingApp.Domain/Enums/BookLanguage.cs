namespace LibraryTrackingApp.Domain.Enums;

/// <summary>
/// Bir kitabın dilini belirtir.
/// </summary>
[Flags]
public enum BookLanguage
{
    /// <summary>
    /// Kitap Türkçe.
    /// </summary>
    Turkish = 1 << 0,

    /// <summary>
    /// Kitap İngilizce.
    /// </summary>
    English = 1 << 1,

    /// <summary>
    /// Kitap Fransızca.
    /// </summary>
    French = 1 << 2,

    /// <summary>
    /// Kitap Almanca.
    /// </summary>
    German = 1 << 3,

    /// <summary>
    /// Kitap İspanyolca.
    /// </summary>
    Spanish = 1 << 4,
}


