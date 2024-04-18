namespace LibraryTrackingApp.Application.DTOs;

public record BaseAuditableDTO<TDTOIdType>
{
    public TDTOIdType Id { get; set; }

    public TDTOIdType CreatedById { get; set; }
    public TDTOIdType? LastModifiedById { get; set; }
    public TDTOIdType? IsDeletedById { get; set; }


    public long CreatedDateUnix { get; set; }
    public long? LastModifiedDateUnix { get; set; }
    public long? DeletedDateUnix { get; set; }

    public bool IsDeleted { get; set; } = false;

    // DateTime'ı Unix zaman damgasına dönüştürme fonksiyonu
    public static long ToUnixTimestamp(DateTime dateTime)
    {
        return (long)dateTime.ToLocalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }

    // Unix zaman damgasını DateTime'a dönüştürme fonksiyonu
    public static DateTime FromUnixTimestamp(long unixTime)
    {
        return DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
    }
}
