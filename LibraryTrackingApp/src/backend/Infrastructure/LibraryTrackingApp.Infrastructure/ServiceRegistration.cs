using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Helpers;
using LibraryTrackingApp.Infrastructure.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryTrackingApp.Infrastructure;


public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.ConfigureSwagger(LayerName.WebAPI);
    }
}
