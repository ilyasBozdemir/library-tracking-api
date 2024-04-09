using Microsoft.EntityFrameworkCore;

namespace LibraryTrackingApp.Application.Features.Behaviors;

public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    private readonly DbContext _dbContext;

    public TransactionBehavior(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        //using var transaction = await _dbContext.Database.BeginTransactionAsync();
        //try
        //{
        //    var response = await next();
        //    await _dbContext.SaveChangesAsync();
        //    await transaction.CommitAsync();
      
        //}
        //catch
        //{
        //    await transaction.RollbackAsync();
        //    throw;
        //}
        return await next();
    }
}