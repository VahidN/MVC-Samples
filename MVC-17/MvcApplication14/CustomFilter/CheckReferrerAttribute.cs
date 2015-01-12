using System.Web.Mvc;

namespace MvcApplication14.CustomFilter
{
    public class CheckReferrerAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext != null)
            {
                if (filterContext.HttpContext.Request.UrlReferrer == null)
                    throw new System.Web.HttpException("Invalid submission");

                if (filterContext.HttpContext.Request.UrlReferrer.Host != "mysite.com")
                    throw new System.Web.HttpException("This form wasn't submitted from this site!");
            }

            base.OnAuthorization(filterContext);
        }
    }
}