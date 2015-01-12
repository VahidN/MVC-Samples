using System.Web.Mvc;

namespace MvcApplication13.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Forbidden()
        {
            return View();
        }

        public ActionResult InternalServerError()
        {
            return View();
        }
    }
}
