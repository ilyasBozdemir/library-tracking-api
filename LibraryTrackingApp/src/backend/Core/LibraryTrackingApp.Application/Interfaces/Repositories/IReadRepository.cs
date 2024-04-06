using LibraryTrackingApp.Application.Shared.Wrappers.Paging;
using LibraryTrackingApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryTrackingApp.Application.Interfaces.Repositories;

public interface IReadRepository<T, TKey>
where T : BaseEntity<TKey>
{
    DbSet<T> Table { get; }
    IQueryable<T> GetAll(bool tracking = true);
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T> GetByIdAsync(TKey id, bool tracking = true);

    Task<Paginate<T>> GetPaginatedAsync(PaginationInfo paginationInfo, bool tracking = true);
    Task<Paginate<T>> GetPaginatedAsync(
        Expression<Func<T, bool>> filter,
        PaginationInfo paginationInfo,
        bool tracking = true
    );
}
