namespace LibraryTrackingApp.Domain.Entities;

public abstract class BaseEntity<TEntityIdType> : IEntity<TEntityIdType>
{
    public TEntityIdType Id { get; set; }

    public TEntityIdType CreatedById { get; set; }
    public TEntityIdType? LastModifiedById { get; set; }
    public TEntityIdType? IsDeletedById { get; set; }


    public long CreatedDateUnix { get; set; }
    public long? LastModifiedDateUnix { get; set; }
    public long? DeletedDateUnix { get; set; }


    public bool IsDeleted { get; set; } = false; // testler tamamlanınca silindi gösterilcektir datalar.

   
}

public  class BaseEntity
{
    // DateTime'ı Unix zaman damgasına dönüştürme fonksiyonu
    public static long  ToUnixTimestamp(DateTime dateTime)
    {
        return (long)dateTime.ToLocalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }

    // Unix zaman damgasını DateTime'a dönüştürme fonksiyonu
    public static DateTime FromUnixTimestamp(long unixTime)
    {
        return DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
    }
}