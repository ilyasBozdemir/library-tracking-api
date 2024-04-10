using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class ParameterOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        // API işlemine gelen veya giden parametreye özel ayarlar ekleme
        foreach (var parameter in operation.Parameters)
        {
            // Örnek olarak, parametrelerin açıklamalarını güncelleme
            parameter.Description = "Bu parametre özelleştirilmiş bir açıklamaya sahiptir.";
        }
    }
}
