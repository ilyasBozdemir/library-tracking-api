namespace LibraryTrackingApp.Domain.Interfaces;

public interface IAuditable<TEntityIdType>
{
    TEntityIdType CreatedById { get; set; }
    string CreatedBy { get; set; }
    DateTime CreatedDate { get; set; }
    string? LastModifiedBy { get; set; }
    DateTime? LastModifiedDate { get; set; }
}
