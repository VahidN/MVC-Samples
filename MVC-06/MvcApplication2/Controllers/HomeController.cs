using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        [NonAction]
        public string ShowData()
        {
            return "Text";
        }

        public ActionResult Index()
        {
            ViewBag.Message = string.Format("{0}/{1}/{2}",
                                              RouteData.Values["controller"],
                                              RouteData.Values["action"],
                                              RouteData.Values["id"]);
            return View();
        }

        public ActionResult Search(string data = "*")
        {
            // do something ...
            return View();
        }
    }
}