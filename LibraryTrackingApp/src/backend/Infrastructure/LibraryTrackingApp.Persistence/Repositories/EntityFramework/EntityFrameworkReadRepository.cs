using Microsoft.EntityFrameworkCore;
using LibraryTrackingApp.Application.Shared.Wrappers.Extensions;

namespace LibraryTrackingApp.Persistence.Repositories.EntityFramework;


public class EntityFrameworkReadRepository<TEntity, TKey> : IReadRepository<TEntity, TKey>
    where TEntity : BaseEntity<TKey>

{

    private readonly AppIdentityDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public EntityFrameworkReadRepository(AppIdentityDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>();
    }


    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task<int> CountAsync()
    {
        return await Table.CountAsync();
    }

    public async Task<bool> ExistsAsync(Func<TEntity, bool> filter)
    {
        return await Task.Run(() => Table.Any(filter));
    }


    public IQueryable<TEntity> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }


    public async Task<TEntity> GetByIdAsync(TKey id, bool tracking = true)
    {
        if (tracking)
           return await Table.FindAsync(id);
        else
            return await Table.AsNoTracking().FirstOrDefaultAsync(e => e.Id.Equals(id));
        
    }

    public async Task<Paginate<TEntity>> GetPaginatedAsync(Expression<Func<TEntity, bool>> filter, int pageIndex, int pageSize, bool tracking = true)
    {
        var query = Table.Where(filter);

        if (!tracking)
            query = query.AsNoTracking();

        return await query.PaginateAsync(pageIndex, pageSize);
    }
    public async Task<Paginate<TEntity>> GetPaginatedAsync(int pageIndex, int pageSize, bool tracking = true)
    {
        var query = Table.AsQueryable();

        if (!tracking)
            query = query.AsNoTracking();

        return await query.PaginateAsync(pageIndex, pageSize);
    }


    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = Table.AsNoTracking();
        return await query.FirstOrDefaultAsync(method);
    }

    public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true)
    {
        var query = Table.Where(method);
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }
}
