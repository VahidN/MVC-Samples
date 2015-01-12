using System;
using System.Web.Mvc;

namespace MvcApplication13.Controllers
{
    public class HomeController : Controller
    {
        [HandleError(View = "~/Views/SomeLocation/Index.cshtml")]
        //[HandleError(ExceptionType = typeof(NullReferenceException), View = "LameErrorHandling")]
        public ActionResult Index()
        {
            throw new InvalidOperationException();
            return View();
        }
    }
}
