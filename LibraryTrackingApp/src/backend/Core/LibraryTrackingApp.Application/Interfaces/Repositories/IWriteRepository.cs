using LibraryTrackingApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryTrackingApp.Application.Interfaces.Repositories;

public interface IWriteRepository<TEntity, TKey>
    where TEntity : BaseEntity<TKey>
{
    DbSet<TEntity> Table { get; }
    Task<bool> AddAsync(TEntity model);
    Task<bool> AddRangeAsync(IEnumerable<TEntity> datas);
    Task<bool> DeleteAsync(TEntity entity);
    Task<bool> DeleteRangeAsync(IEnumerable<TEntity> entities);
    Task<bool> UpdateAsync(TEntity entity);
    Task SoftDeleteAsync(TEntity entity);
    Task SoftDeleteRangeAsync(IEnumerable<TEntity> entities);
    Task RestoreAsync(TEntity entity);
    Task RestoreRangeAsync(IEnumerable<TEntity> entities);
    Task<int> SaveAsync();
}
