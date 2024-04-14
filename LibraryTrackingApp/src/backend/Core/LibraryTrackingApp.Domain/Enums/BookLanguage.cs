namespace LibraryTrackingApp.Domain.Enums;

[Flags]
public enum BookLanguage
{
    Turkish = 1 << 0,
    English = 1 << 1,
    French = 1 << 2,
    German = 1 << 3,
    Spanish = 1 << 4,
}

