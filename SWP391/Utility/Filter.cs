using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace SWP391.Utility
{
    public class Filter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            if (!context.HttpContext.User.Identity.IsAuthenticated && context.HttpContext.Request.Cookies["user"] == null)
            {
                context.Result = new RedirectResult($"~/login");
            }
            else
            {
                return;
            }
        }
    }
}
