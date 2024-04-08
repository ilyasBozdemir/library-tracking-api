namespace LibraryTrackingApp.Persistence.Repositories.EntityFramework;

public class EntityFrameworkWriteRepository<TEntity, TKey> : IWriteRepository<TEntity, TKey>
    where TEntity : BaseEntity<TKey>
{
    public DbSet<TEntity> Table => throw new NotImplementedException();


    private readonly AppIdentityDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public EntityFrameworkWriteRepository(AppIdentityDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>();
    }


    public async Task<bool> AddAsync(TEntity model)
    {
        await _context.Set<TEntity>().AddAsync(model);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> AddRangeAsync(IEnumerable<TEntity> datas)
    {
        await _context.Set<TEntity>().AddRangeAsync(datas);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteRangeAsync(IEnumerable<TEntity> entities)
    {
        _context.Set<TEntity>().RemoveRange(entities);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task RestoreAsync(TEntity entity)
    {
        entity.IsDeleted = false;
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task RestoreRangeAsync(IEnumerable<TEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.IsDeleted = false;
            _context.Entry(entity).State = EntityState.Modified;
        }
        await _context.SaveChangesAsync();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task SoftDeleteAsync(TEntity entity)
    {
        entity.IsDeleted = true;
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task SoftDeleteRangeAsync(IEnumerable<TEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.IsDeleted = true;
            _context.Entry(entity).State = EntityState.Modified;
        }
        await _context.SaveChangesAsync();
    }

    public async Task<bool> UpdateAsync(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        return await _context.SaveChangesAsync() > 0;
    }

}
