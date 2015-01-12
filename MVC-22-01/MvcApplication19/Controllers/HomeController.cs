using System.Web.Mvc;
using MvcApplication19.Models;
using System;

namespace MvcApplication19.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 60, VaryByHeader = "Accept-Language")]
        public ActionResult Index()
        {
            //throw new Exception();
            var employee = new Employee { Name = "Name 1" };
            return View(employee);
        }
    }
}
