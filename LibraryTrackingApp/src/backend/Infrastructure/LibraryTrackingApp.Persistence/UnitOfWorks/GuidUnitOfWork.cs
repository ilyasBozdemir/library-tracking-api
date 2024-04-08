namespace LibraryTrackingApp.Persistence.UnitOfWorks;


public class GuidUnitOfWork<Guid> : IUnitOfWork<Guid>
{
    private readonly AppIdentityDbContext _context;

    public GuidUnitOfWork(AppIdentityDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IReadRepository<TEntity, Guid> GetReadRepository<TEntity>() where TEntity : BaseEntity<Guid>
    {
        return new EntityFrameworkReadRepository<TEntity, Guid>(_context);
    }

    public IWriteRepository<TEntity, Guid> GetWriteRepository<TEntity>() where TEntity : BaseEntity<Guid>
    {
        return new EntityFrameworkWriteRepository<TEntity, Guid>(_context);
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
