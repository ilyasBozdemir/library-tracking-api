using LibraryTrackingApp.Application.Interfaces.Services.Security;
using LibraryTrackingApp.Infrastructure.Enums;
using LibraryTrackingApp.Infrastructure.Helpers;
using LibraryTrackingApp.Infrastructure.Security;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryTrackingApp.Infrastructure;


public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.ConfigureSwagger(LayerName.WebAPI);


        services.AddScoped<ITokenHandler, JwtTokenHandler>();

          
    }
}
