namespace LibraryTrackingApp.Domain.Interfaces;

public interface IAuditable<TEntityIdType>
{
    public TEntityIdType CreatedById { get; set; }
    public TEntityIdType? LastModifiedById { get; set; }
    public TEntityIdType? IsDeletedById { get; set; }


    public long CreatedDateUnix { get; set; }
    public long? LastModifiedDateUnix { get; set; }
    public long? DeletedDateUnix { get; set; }
}
