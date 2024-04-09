using LibraryTrackingApp.Application.Interfaces.Repositories;
using LibraryTrackingApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace LibraryTrackingApp.Application.Interfaces.UnitOfWork;

public interface IUnitOfWork<TKey> : IDisposable 
{
    IReadRepository<T, TKey> GetReadRepository<T>() where T : BaseEntity<TKey>;
    IWriteRepository<T, TKey> GetWriteRepository<T>() where T : BaseEntity<TKey>;
    IExecutionStrategy CreateExecutionStrategy();
    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task RollbackAsync(CancellationToken cancellationToken = default);
    Task CommitAsync(CancellationToken cancellationToken = default);
    Task<int> SaveAsync(CancellationToken cancellationToken = default);
}
