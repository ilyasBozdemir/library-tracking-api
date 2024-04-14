using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryTrackingApp.Application.Authorization.Policies;

public static class CorsPolicies
{
    public static void AddCorsPolicies(this IServiceCollection services)
    {
        services.AddCors(options =>
        {

            options.AddPolicy("AllowLocalhost3000",
              builder => builder
              .WithOrigins("http://localhost:3000")
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials());
        });
    }
    public static void UseCustomCorsPolicies(this IApplicationBuilder app)
    {
        app.UseCors("AllowLocalhost3000");
    }
}
