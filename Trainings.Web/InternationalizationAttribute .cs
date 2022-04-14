using Microsoft.AspNetCore.Mvc.Filters;
using System.Globalization;

public class InternationalizationAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        var cultureInfo = CultureInfo.GetCultureInfo("ru-RU");

        Thread.CurrentThread.CurrentCulture = cultureInfo;
        Thread.CurrentThread.CurrentUICulture = cultureInfo;
    }
}