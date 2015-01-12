using System.Web.Mvc;
using MvcApplication12.CustomFilters;

namespace MvcApplication12.Controllers
{
    [Log]
    public class HomeController : Controller
    {
        //[AuthorizationFilterA(Order = 2)]
        //[AuthorizationFilterB(Order = 1)]
        //[Log]
        public ActionResult Index()
        {
            return View();
        }

        //[Log]
        public ActionResult Test()
        {
            return View();
        }
    }
}
