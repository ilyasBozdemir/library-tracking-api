namespace LibraryTrackingApp.Domain.Enums;

[Flags]
public enum BookStatus
{
    Active = 0,  // Aktif
    Inactive,    // Pasif
    Available,  // Mevcut
    Borrowed,   // Ödünç Alınmış
    Reserved,   // Rezerve Edilmiş
    Damaged,    // Hasarlı
    Lost        // Kayıp
}
