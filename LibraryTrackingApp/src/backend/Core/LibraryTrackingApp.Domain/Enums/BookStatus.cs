namespace LibraryTrackingApp.Domain.Enums;

[Flags]
public enum BookStatus
{
    Active = 1 << 0,    // 1
    Inactive = 1 << 1,  // 2
    Available = 1 << 2, // 4
    Borrowed = 1 << 3,  // 8
    Reserved = 1 << 4,  // 16
    Damaged = 1 << 5,   // 32
    Lost = 1 << 6       // 64
}
