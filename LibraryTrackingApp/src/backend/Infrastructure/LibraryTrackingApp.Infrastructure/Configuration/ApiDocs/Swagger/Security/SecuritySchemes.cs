using Microsoft.OpenApi.Models;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Security;

public static class SecuritySchemes
{
    public static OpenApiSecurityScheme BearerSecurityScheme { get; } = new OpenApiSecurityScheme()
    {
        Description = "JWT Authorization header using the Bearer scheme",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
    };
}
