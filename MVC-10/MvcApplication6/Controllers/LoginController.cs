using System.Web.Mvc;
using MvcApplication6.Models;

namespace MvcApplication6.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            return View(); //Shows the login page
        }

        [HttpPost]
        public ActionResult LoginResult()
        {
            string name = Request.Form["name"];
            string password = Request.Form["password"];

            if (name == "Vahid" && password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }

        [HttpPost]
        //[ActionName("LoginResultWithFormCollection")]
        public ActionResult LoginResult(FormCollection collection)
        {
            string name = collection["name"];
            string password = collection["password"];

            if (name == "Vahid" && password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }

        [HttpPost]
        public ActionResult LoginResultUpdateFormCollection(FormCollection collection)
        {
            var account = new Account();
            this.UpdateModel(account, collection.ToValueProvider());

            if (account.Name == "Vahid" && account.Password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }

        [HttpPost]
        public ActionResult LoginResultUpdateModel()
        {
            var account = new Account();
            this.UpdateModel(account);

            if (account.Name == "Vahid" && account.Password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }

        [HttpPost]
        [ActionName("LoginResultWithParams")]
        public ActionResult LoginResult(string name, string password)
        {
            if (name == "Vahid" && password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            if (account.Name == "Vahid" && account.Password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }
    }
}
