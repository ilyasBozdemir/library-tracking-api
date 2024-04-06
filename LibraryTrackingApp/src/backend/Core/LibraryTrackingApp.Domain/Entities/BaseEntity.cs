using LibraryTrackingApp.Domain.Interfaces;

namespace LibraryTrackingApp.Domain.Entities;

public abstract class BaseEntity<TEntityIdType> :  ISoftDeletable
{
    public TEntityIdType Id { get; set; }
    TEntityIdType CreatedById { get; set; }
    DateTime CreatedDate { get; set; }
    string? LastModifiedBy { get; set; }
    DateTime? LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }

    protected BaseEntity()
    {
        CreatedDate = DateTime.Now;
        IsDeleted = false;
    }
}