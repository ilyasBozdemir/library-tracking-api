namespace LibraryTrackingApp.Domain.Enums;

/// <summary>
/// Bir eserin formatını belirtir.
/// </summary>
[Flags]
public enum WorkFormat
{
    /// <summary>
    /// Eser basılı formatta.
    /// </summary>
    PrintedBook = 1 << 0,

    /// <summary>
    /// Eser elektronik formatta.
    /// </summary>
    EBook = 1 << 1,

    /// <summary>
    /// Eser sesli formatta.
    /// </summary>
    AudioBook = 1 << 2,


    /// <summary>
    /// Eser dergi formatında.
    /// </summary>
    Magazine = 1 << 3,

    /// <summary>
    /// Eser tez formatında.
    /// </summary>
    Thesis = 1 << 4,

    /// <summary>
    /// Eser öneri formatında.
    /// </summary>
    Recommendation = 1 << 5

}