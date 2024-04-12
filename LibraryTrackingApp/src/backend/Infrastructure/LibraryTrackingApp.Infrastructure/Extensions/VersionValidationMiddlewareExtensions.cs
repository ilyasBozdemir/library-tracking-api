using LibraryTrackingApp.Infrastructure.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace LibraryTrackingApp.Infrastructure.Extensions;

public static class VersionValidationMiddlewareExtensions
{
    public static IApplicationBuilder UseVersionValidation(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<VersionValidationMiddleware>();
    }
}
