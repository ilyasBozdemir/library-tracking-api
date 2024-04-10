using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class DocumentationOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        // API işlemine özel dokümantasyon ekleme
        operation.Description = "Bu API işlemi özelleştirilmiş bir açıklamaya sahiptir.";
    }
}
