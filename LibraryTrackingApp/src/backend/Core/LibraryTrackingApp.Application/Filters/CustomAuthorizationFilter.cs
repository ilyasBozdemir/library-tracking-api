using Microsoft.AspNetCore.Mvc.Filters;

namespace LibraryTrackingApp.Application.Filters;

public class CustomAuthorizationFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        //jwt middlewaree ile de yapılır bununla da
    }
}