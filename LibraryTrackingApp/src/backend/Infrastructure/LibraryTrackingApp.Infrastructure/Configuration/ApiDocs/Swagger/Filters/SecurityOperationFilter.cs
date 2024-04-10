using System.Collections.Generic;
using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Security;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class SecurityOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Security.Add(OpenApiSecurityRequirements.BearerSecurityRequirement);
    }
}

