using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Any;
using LibraryTrackingApp.Domain.Enums;
using LibraryTrackingApp.Domain.Constants;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class EnumDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        AddEnumToSwagger<WorkFormat>(swaggerDoc, "Kitabın formatını temsil eden bir enum.");
        AddEnumToSwagger<WorkStatus>(swaggerDoc, "Kitabın durumunu temsil eden bir enum.");
        AddEnumToSwagger<BorrowStatus>(swaggerDoc, "Kitabın ödünç durumunu temsil eden bir enum.");
        AddEnumToSwagger<TransactionType>(swaggerDoc, "Kitap işleminin türünü temsil eden bir enum.");

        var externalDocs = new OpenApiExternalDocs
        {
            Description = "Daha fazla bilgi için Githuba göz atın.",
            Url = new Uri(AppConstant.projectGithubUrl)
        };

        swaggerDoc.ExternalDocs = externalDocs;

    }
    public void AddEnumToSwagger<TEnum>(OpenApiDocument swaggerDoc, string description)
    {
        var enumType = typeof(TEnum);
        var enumSchema = new OpenApiSchema
        {
            Type = "string",
            Enum = Enum.GetValues(enumType)
                   .Cast<Enum>()
                   .Select(e => new OpenApiString(e.ToString()) as IOpenApiAny)
                   .ToList(),
            Description = description,
        };

        if (!swaggerDoc.Components.Schemas.ContainsKey(enumType.Name))
            swaggerDoc.Components.Schemas.Add(enumType.Name, enumSchema);
        else
            swaggerDoc.Components.Schemas[enumType.Name] = enumSchema;
    }
}
