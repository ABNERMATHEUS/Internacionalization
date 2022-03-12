using System.Globalization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Internacionalization.Utils;

public class TranslateInternacionalization : ActionFilterAttribute
{
    public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var languagecode = context.HttpContext.Request.Headers["language-code"].ToString();
        if (languagecode != null)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languagecode);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
        return base.OnActionExecutionAsync(context, next);
    }
}