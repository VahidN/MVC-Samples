using System;
using System.Web.Mvc;

namespace MvcApplication16.Helper
{
    /// <summary>
    /// Adds "Cache-Control: private, max-age=0" header,
    /// ensuring that the responses are not cached by the user's browser. 
    /// </summary>
    public class NoCachingAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            filterContext.HttpContext.Response.CacheControl = "private";
            filterContext.HttpContext.Response.Cache.SetMaxAge(TimeSpan.FromSeconds(0));
        }
    }
}