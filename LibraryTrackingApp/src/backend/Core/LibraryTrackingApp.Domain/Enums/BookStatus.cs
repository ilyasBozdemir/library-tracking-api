namespace LibraryTrackingApp.Domain.Enums;

[Flags]
public enum BookStatus
{
    Available = 0,  // Mevcut
    Borrowed,   // Ödünç Alınmış
    Reserved,   // Rezerve Edilmiş
    Damaged,    // Hasarlı
    Lost        // Kayıp
}
