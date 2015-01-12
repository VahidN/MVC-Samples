using System;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.Caching;
using System.Web;
using MvcApplication16.Helper;

namespace MvcApplication16.Controllers
{

    //[CustomAuthorizeAttribute]
    public class HomeController : Controller
    {
        [OutputCache(CacheProfile = "Aggressive", VaryByParam = "parameter")]
        public ActionResult Index(string parameter)
        {
            ViewBag.Msg = parameter ?? string.Empty;
            ViewBag.ControllerTime = DateTime.Now;
            
            //HttpContext.CacheInsert("myKey", listSourceHelper, 10);


            return View();
        }
    }
}
