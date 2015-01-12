using System.Web.Mvc;
using MvcApplication9.Models;
using System.Web.UI;

namespace MvcApplication9.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            var customer = new Customer();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (this.ModelState.IsValid)
            {
                //todo: save data
                return Redirect("/");
            }
            return View(customer);
        }

        [HttpPost]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public ActionResult CheckUserNameAndEmail(string name, string email)
        {
            if (name.ToLowerInvariant() == "vahid") return Json(false);
            if (email.ToLowerInvariant() == "name@site.com") return Json(false);
            //...
            return Json(true);
        }

    }
}
