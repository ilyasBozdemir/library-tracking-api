using LibraryTrackingApp.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LibraryTrackingApp.Infrastructure.Middlewares;

public class VersionValidationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly VersionService _versionService;

    public VersionValidationMiddleware(RequestDelegate next, VersionService versionService)
    {
        _next = next;
        _versionService = versionService;
    }

    public async Task Invoke(HttpContext context)
    {
        var requestedVersion = context.GetRequestedApiVersion()?.ToString();
        if (string.IsNullOrEmpty(requestedVersion) || !_versionService.GetAllVersions().Contains(requestedVersion))
        {
            context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            await context.Response.WriteAsync($"İstenen '{requestedVersion}' sürümü desteklenmiyor.");
            return;
        }

        await _next(context);
    }
}
