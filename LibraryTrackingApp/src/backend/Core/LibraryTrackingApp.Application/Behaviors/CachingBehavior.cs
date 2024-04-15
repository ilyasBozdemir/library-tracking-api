using LibraryTrackingApp.Application.Interfaces.Caching;

namespace LibraryTrackingApp.Application.Behaviors;

public class CachingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TResponse : class
{
    private readonly ICacheService _cacheService;

    public CachingBehavior(ICacheService cacheService)
    {
        _cacheService = cacheService;
    }
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var cacheKey = GenerateCacheKeyFromRequest(request);
        var cachedResponse = await _cacheService.GetAsync<TResponse>(cacheKey);
        if (cachedResponse != null)
        {
            return cachedResponse;
        }

        var response = await next();
        await _cacheService.SetAsync(cacheKey, response);

        return await next();

    }
    private static string GenerateCacheKeyFromRequest(TRequest request)
    {
        // Örnek bir cache anahtarı oluşturma:
        var cacheKey = $"{typeof(TRequest).FullName}:{request.ToString()}";

        return cacheKey;
    }

}