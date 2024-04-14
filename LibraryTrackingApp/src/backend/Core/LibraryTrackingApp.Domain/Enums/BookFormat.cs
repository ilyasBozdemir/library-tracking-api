namespace LibraryTrackingApp.Domain.Enums;

[Flags]
public enum BookFormat
{
    PrintedBook = 1 << 0,
    EBook = 1 << 1,
    AudioBook = 1 << 2
}

