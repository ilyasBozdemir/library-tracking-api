using LibraryTrackingApp.Application.Shared.Wrappers.Paging;
using LibraryTrackingApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryTrackingApp.Application.Interfaces.Repositories;

public interface IReadRepository<TEntity, TKey>
where TEntity : BaseEntity<TKey>
{
    DbSet<TEntity> Table { get; }
    IQueryable<TEntity> GetAll(bool tracking = true);
    IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true);
    Task<IEnumerable<TEntity>> GetByFilterAsync(Func<TEntity, bool> filter);
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true);
    Task<TEntity> GetByIdAsync(TKey id, bool tracking = true);
    Task<IEnumerable<TEntity>> GetRelatedEntitiesAsync(Guid id);
    Task<TEntity> GetFirstOrDefaultAsync(Func<TEntity, bool> filter);
    Task<int> CountAsync();

    Task<bool> ExistsAsync(Func<TEntity, bool> filter);
    Task<Paginate<TEntity>> GetPaginatedAsync(int pageNumber, int pageSize, bool tracking = true);
    Task<Paginate<TEntity>> GetPaginatedAsync(
        Expression<Func<TEntity, bool>> filter,
        int pageNumber, int pageSize,
        bool tracking = true
    );
}
