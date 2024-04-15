namespace LibraryTrackingApp.Domain.Entities;

public abstract class BaseEntity<TEntityIdType> : IEntity<TEntityIdType>
{
    public TEntityIdType Id { get; set; }
    TEntityIdType CreatedById { get; set; }
    DateTime CreatedDate { get; set; }
    string? LastModifiedBy { get; set; }
    DateTime? LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }

    //CreatedDate ve LastModifiedDate bunlar unix timestamp olarka cevrilcektir.

    protected BaseEntity()
    {
        CreatedDate = DateTime.Now;
        IsDeleted = false;
    }
}