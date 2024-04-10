using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class HeaderParameter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (operation.Parameters == null)
            operation.Parameters = new List<OpenApiParameter>();

        AddParameterIfNotExists(operation, "corid", "Request/Response trace identifier", ParameterLocation.Header, false, "string");
        AddParameterIfNotExists(operation, "spanid", "Request/Response span trace identifier", ParameterLocation.Header, false, "string");
        AddParameterIfNotExists(operation, "ctxid", "Request context Id/UID", ParameterLocation.Header, false, "string");
        AddParameterIfNotExists(operation, "lang", "Language identifier for request. Valid values are : [tr-TR | en-US]. Values are based on ISO Language Code Table ([ISO Language Code Table](http://www.lingoes.net/en/translator/langcode.htm))", ParameterLocation.Header, false, "string");

    }
    private void AddParameterIfNotExists(OpenApiOperation operation, string name, string description, ParameterLocation location, bool required, string type)
    {
        if (!operation.Parameters.Any(p => p.Name == name))
        {
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = name,
                In = location,
                Description = description,
                Required = required,
                Schema = new OpenApiSchema
                {
                    Type = type
                }
            });
        }
    }
}