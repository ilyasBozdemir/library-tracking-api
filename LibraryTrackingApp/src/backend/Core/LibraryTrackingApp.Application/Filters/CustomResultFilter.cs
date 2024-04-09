using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LibraryTrackingApp.Application.Filters;

public class CustomResultFilter : IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        // Sonuç başlamadan önce
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        // Sonuç tamamlandıktan sonra
    }
}
