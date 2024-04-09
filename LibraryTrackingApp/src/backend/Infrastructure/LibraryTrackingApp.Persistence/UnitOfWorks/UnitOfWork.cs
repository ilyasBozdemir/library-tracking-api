using Microsoft.EntityFrameworkCore.Storage;

namespace LibraryTrackingApp.Persistence.UnitOfWorks;

// serilog eklenecek 
public class UnitOfWork<TKey> : IUnitOfWork<TKey>
{
    private readonly AppIdentityDbContext _context;
    private IDbContextTransaction _transaction;

    public UnitOfWork(AppIdentityDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IReadRepository<TEntity, TKey> GetReadRepository<TEntity>() where TEntity : BaseEntity<TKey>
    {
        return new EntityFrameworkReadRepository<TEntity, TKey>(_context);
    }

    public IWriteRepository<TEntity, TKey> GetWriteRepository<TEntity>() where TEntity : BaseEntity<TKey>
    {
        return new EntityFrameworkWriteRepository<TEntity, TKey>(_context);
    }

    public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        _transaction = await _context.Database.BeginTransactionAsync(cancellationToken);
        return _transaction;
    }

    public async Task RollbackAsync(CancellationToken cancellationToken = default)
    {
        if (_transaction != null)
        {
            await _transaction.RollbackAsync(cancellationToken);
            _transaction.Dispose();
        }
    }

    public async Task CommitAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            await _context.SaveChangesAsync(cancellationToken);
            if (_transaction != null)
            {
                await _transaction.CommitAsync(cancellationToken);
                _transaction.Dispose();
            }
        }
        catch
        {
            await RollbackAsync(cancellationToken);
            throw;
        }
    }

    public IExecutionStrategy CreateExecutionStrategy()
    {
        return _context.Database.CreateExecutionStrategy();
    }
    public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}
