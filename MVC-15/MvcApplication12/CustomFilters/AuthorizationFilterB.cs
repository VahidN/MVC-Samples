using System.Diagnostics;
using System.Web.Mvc;

namespace MvcApplication12.CustomFilters
{
    public class AuthorizationFilterB : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            Debug.WriteLine("OnAuthorization : AuthorizationFilterB");
        }
    }
}