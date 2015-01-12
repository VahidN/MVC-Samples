using System.Web.Mvc;

namespace MvcApplication15.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Users="Vahid1")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
