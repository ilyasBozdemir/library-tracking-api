namespace LibraryTrackingApp.Domain.Interfaces;

public interface IEntity<TEntityIdType> 
{
    TEntityIdType Id { get; set; }
}
