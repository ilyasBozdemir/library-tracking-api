using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class CustomMetadataOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Extensions.Add("x-custom-metadata", new OpenApiString("Bu özel meta veri API işlemine aittir."));
    }
}
