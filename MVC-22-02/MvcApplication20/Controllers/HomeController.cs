using System.Web.Mvc;
using MvcApplication20.Models;

namespace MvcApplication20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = new User { Id = 1, Name = "name 1" };
            return View(user);
        }
    }
}
