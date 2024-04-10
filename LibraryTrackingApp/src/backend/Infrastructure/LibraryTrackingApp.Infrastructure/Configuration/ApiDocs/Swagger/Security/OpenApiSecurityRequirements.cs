using Microsoft.OpenApi.Models;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Security;

public static class OpenApiSecurityRequirements
{
    public static OpenApiSecurityRequirement BearerSecurityRequirement { get; } = new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    };
}