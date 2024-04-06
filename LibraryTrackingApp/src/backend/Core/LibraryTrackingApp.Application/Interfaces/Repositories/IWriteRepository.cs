using LibraryTrackingApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryTrackingApp.Application.Interfaces.Repositories;

public interface IWriteRepository<T, TKey>
    where T : BaseEntity<TKey>
{
    DbSet<T> Table { get; }
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T model);
    bool RemoveRange(List<T> datas);
    Task<bool> RemoveAsync(string id);
    bool Update(T model);
    Task<int> SaveAsync();
}
