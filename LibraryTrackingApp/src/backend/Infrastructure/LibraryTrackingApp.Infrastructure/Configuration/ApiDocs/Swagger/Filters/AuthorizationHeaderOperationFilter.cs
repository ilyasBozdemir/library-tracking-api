using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class AuthorizationHeaderOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        // Eğer bu bir controller action değilse veya [AllowAnonymous] özniteliği varsa işlem yapma
        if (!context.ApiDescription.TryGetMethodInfo(out MethodInfo methodInfo) ||
            methodInfo.GetCustomAttributes<AllowAnonymousAttribute>().Any())
        {
            return;
        }

        // Eğer bu bir Authorization gerektiren endpointse
        if (methodInfo.GetCustomAttributes<AuthorizeAttribute>().Any())
        {
            // Header'a "Authorization" parametresi ekle
            operation.Parameters ??= new List<OpenApiParameter>();
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Authorization",
                In = ParameterLocation.Header,
                Description = "Client authorization access token [Authorization : Bearer {accesstoken} ]",
                Required = true,
                Schema = new OpenApiSchema
                {
                    Type = "string"
                }
            });
        }
    }
}
