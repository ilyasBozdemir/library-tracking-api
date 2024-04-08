using LibraryTrackingApp.Application.Interfaces.Repositories;
using LibraryTrackingApp.Domain.Entities;

namespace LibraryTrackingApp.Application.Interfaces.UnitOfWork;


public interface IUnitOfWork<TKey> : IDisposable 
{
    IReadRepository<T, TKey> GetReadRepository<T>() where T : BaseEntity<TKey>;
    IWriteRepository<T, TKey> GetWriteRepository<T>() where T : BaseEntity<TKey>;
    Task<int> SaveAsync();
}
