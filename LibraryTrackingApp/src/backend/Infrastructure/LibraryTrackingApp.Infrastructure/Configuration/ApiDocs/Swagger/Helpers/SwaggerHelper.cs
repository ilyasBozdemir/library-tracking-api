using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;
using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Security;
using LibraryTrackingApp.Infrastructure.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Helpers;

public static class SwaggerHelper
{
    private static IDictionary<string, OpenApiInfo>? apiInfos;

    public static void ConfigureSwagger(this IServiceCollection services, LayerName layerName)
    {
        apiInfos = GetApiInfos(layerName);
        services.AddEndpointsApiExplorer();

        var apiVersions = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(ControllerBase).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
            .SelectMany(t => t.GetCustomAttributes<ApiVersionAttribute>(true))
            .SelectMany(a => a.Versions)
            .Distinct()
            .OrderBy(v => v.ToString());

        // testing...
        services.AddSwaggerGen(c =>
        {
            c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

            foreach (var version in apiVersions)
            {
                var versionStr = $"v{version}";



            }
        });
        /*
        services.AddSwaggerGen(c =>
        {
            c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

            foreach (var version in apiVersions)
            {
                var versionStr = $"v{version}";



                if (apiInfos.TryGetValue(versionStr, out var openApiInfo))
                {
                 
                    c.SwaggerDoc(versionStr, openApiInfo);

                    Console.WriteLine(versionStr);
                    Console.WriteLine(openApiInfo.Title);
                    Console.WriteLine(openApiInfo.Contact.Name);

                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    c.IncludeXmlComments(xmlPath);
                }
                else { }
            }

            c.DocInclusionPredicate(
                (docName, apiDesc) =>
                {
                    if (!apiDesc.TryGetMethodInfo(out MethodInfo methodInfo))
                    {
                        return false;
                    }

                    var versions = methodInfo
                        .DeclaringType?.GetCustomAttributes(true)
                        .OfType<ApiVersionAttribute>()
                        .SelectMany(attr => attr.Versions)
                        .Select(v => $"v{v}");

                    return versions.Any(v => v == docName);
                }
            );

            if (!c.OperationFilterDescriptors.Any(x => x.Type == typeof(SecurityOperationFilter)))
            {
                c.AddSecurityRequirement(OpenApiSecurityRequirements.BearerSecurityRequirement);
                c.AddSecurityDefinition("Bearer", SecuritySchemes.BearerSecurityScheme);
                c.OperationFilter<ParameterOperationFilter>();
                c.OperationFilter<ResponseOperationFilter>();
                c.OperationFilter<SecurityOperationFilter>();
                c.OperationFilter<DocumentationOperationFilter>();
                c.OperationFilter<CustomMetadataOperationFilter>();
                c.OperationFilter<HeaderParameter>();
                c.OperationFilter<AuthorizationHeaderOperationFilter>();


            }
        });
        */
        services.AddApiVersioning(setup =>
        {
            setup.DefaultApiVersion = new ApiVersion(1, 0);
            setup.AssumeDefaultVersionWhenUnspecified = true;
            setup.ReportApiVersions = true;
        });
    }

    public static void UseCustomSwaggerUI(
        this IApplicationBuilder app,
        IWebHostEnvironment env,
        LayerName layerName
    )
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            foreach (var apiVersionInfo in GetAllVersions(layerName))
            {
                c.SwaggerEndpoint(
                    $"/swagger/{apiVersionInfo.Version}/swagger.json",
                    $"{apiVersionInfo.OpenApiInfo.Title}"
                );
            }
        });
    }

    private static IEnumerable<ApiVersionInfo> GetAllVersions(LayerName layerName)
    {
        switch (layerName)
        {
            case LayerName.WebAPI:
                return WebApiVersionInfos.GetAllVersions();

            default:
                throw new ArgumentException("Invalid layer name");
        }
    }

    private static IDictionary<string, OpenApiInfo> GetApiInfos(LayerName layerName)
    {
        // Belirli katman adına göre API OpenAPI bilgilerini döndür
        switch (layerName)
        {
            case LayerName.WebAPI:
                return WebApiVersionInfos
                    .GetAllVersions()
                    .ToDictionary(v => v.Version, v => v.OpenApiInfo);


            default:
                throw new ArgumentException("Invalid layer name");
        }
    }
}