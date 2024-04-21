using LibraryTrackingApp.Domain.Enums;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;


/*

 corid (Correlation ID): İlgili birçok servis çağrısının aynı zincir içinde olduğunu belirten bir kimlik.
Bir istek başladığında oluşturulan bir kimliktir ve bu kimlik tüm istekler boyunca taşınır.
Böylece, farklı servislerdeki log kayıtlarının izlenebilirliği artırılır.

spanid (Span ID): Belirli bir işlem veya istek üzerinde gerçekleşen faaliyetlerin bir zincirini temsil eden bir kimlik. 
Bir isteğin farklı adımları arasındaki ilişkiyi belirlemek için kullanılır.

ctxid (Context ID): İstek veya işlem bağlamını temsil eden bir kimlik. 
Bağlam, bir işlem veya isteğin içinde yer alan ve farklı işlevler arasında taşınan veriler kümesidir. 
Bu kimlik, bir isteğin başladığı yerde oluşturulur ve isteğin tamamı boyunca geçerlidir.

 */


public class HeaderParameter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (operation.Parameters == null)
            operation.Parameters = new List<OpenApiParameter>();

        AddParameterIfNotExists(
            operation,
            "corid",
            "İstek/Yanıt izleme tanımlayıcısı. Bu tanımlayıcı, bir isteğin izleme zincirinde kullanılır. Bir isteğin başlangıcından itibaren oluşturulur ve tüm servis çağrıları boyunca taşınır. Bu kimlik, log kayıtlarını birleştirerek isteğin takibini kolaylaştırır.",
            ParameterLocation.Header,
            false,
            "Guid"
        );
        AddParameterIfNotExists(
            operation,
            "spanid",
            "İstek/Yanıt aralığı izleme tanımlayıcısı. Bu tanımlayıcı, bir işlem veya istek üzerinde gerçekleşen faaliyetlerin bir zincirini temsil eder.",
            ParameterLocation.Header,
            false,
            "Guid"
        );
        AddParameterIfNotExists(
            operation,
            "ctxid",
            "İstek Bağlamı. Bu tanımlayıcı, bir isteğin veya işlemin bağlamını temsil eder.",
            ParameterLocation.Header,
            false,
            "Guid"
        );
        AddParameterIfNotExists(
            operation,
            "lang",
            "İstek için dil tanımlayıcı.",
            ParameterLocation.Header,
            false,
            "Guid",
            new [] { SupportedLanguage.Turkish, SupportedLanguage.English }
        );
    }

    private void AddParameterIfNotExists(
        OpenApiOperation operation,
        string name,
        string description,
        ParameterLocation location,
        bool required,
        string type,
        SupportedLanguage[] supportedLanguages = null
    )
    {
        if (!operation.Parameters.Any(p => p.Name == name))
        {
            var parameter = new OpenApiParameter
            {
                Name = name,
                In = location,
                Description = description,
                Required = required,
                Style=ParameterStyle.Form,
                Schema = new OpenApiSchema { Type = type }
            };


            if (supportedLanguages != null && supportedLanguages.Any())
            {
                parameter.Schema.Enum = supportedLanguages.Select(lang => new OpenApiString($"{lang.IsoCode}")).Cast<IOpenApiAny>().ToList();
            }
            operation.Parameters.Add(parameter);
        }
    }
}
