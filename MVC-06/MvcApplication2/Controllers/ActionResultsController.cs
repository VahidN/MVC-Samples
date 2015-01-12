using System.Web.Mvc;
using System.Web;
using System.Text;

namespace MvcApplication2.Controllers
{
    public class ActionResultsController : Controller
    {
        //http://localhost/actionresults/welcome
        public string Welcome()
        {
            return "Hello, World";
        }

        //http://localhost/actionresults/index
        public ActionResult Index() // or ContentResult
        {
            return Content("Hello, World");
        }

        //http://localhost/actionresults/SendMail
        public void SendMail()
        {
        }

        public ActionResult SendMailCompleted() // or EmptyResult
        {
            // do whatever
            return new EmptyResult();
        }

        public ActionResult GetFile() // or FilePathResult
        {
            return File(Server.MapPath("~/content/site.css"), "text/css", "mySite.css");
        }

        public ActionResult UnauthorizedStatus() // or HttpStatusCodeResult/HttpUnauthorizedResult
        {
            return new HttpUnauthorizedResult("You need to login first.");
        }

        //http://localhost/actionresults/Status
        public ActionResult Status() // or HttpStatusCodeResult
        {            
            return new HttpStatusCodeResult(501,  HttpUtility.UrlEncode("است Server Error", Encoding.UTF8)); // اين فقط با آي آي اس كار مي‌كند
        }

        public ActionResult GetJavaScript() // or JavaScriptResult
        {
            return JavaScript("...JavaScript...");
        }

        public ActionResult GetJson() // or JsonResult
        {
            var obj = new { prop1 = 1, prop2 = "data" };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RedirectTo() // or RedirectResult
        {
            return RedirectPermanent("http://www.site.com");
            //return RedirectToAction("Home", "Index");
        }

        public ActionResult ShowView() // or ViewResult
        {
            return View();
        }
    }
}
