using Microsoft.AspNetCore.Mvc.Filters;

namespace LibraryTrackingApp.Application.Filters;

public class CustomResourceFilter : IResourceFilter
{
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        // Kaynak başlamadan önce
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        // Kaynak tamamlandıktan sonra
    }
}