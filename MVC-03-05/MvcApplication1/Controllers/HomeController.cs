using System;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult InsertData(string name)
        {
            // Check for input errors.
            if (string.IsNullOrWhiteSpace(name))
            {
                TempData["error"] = "name is required.";
                return RedirectToAction("ShowError");
            }
            // No errors
            // ...
            return View();
        }

        public ActionResult ShowError()
        {
            var error = TempData["error"] as string;
            if (!string.IsNullOrWhiteSpace(error))
            {
                ViewBag.Error = error;
            }
            return View();
        }


        public ActionResult Index()
        {
            ViewBag.Country = "Iran";

            var employee = new Employee
            {
                Email = "name@site.com",
                FirstName = "Vahid",
                LastName = "N."
            };

            ViewData["DateTime"] = "<br/>" + DateTime.Now;

            return View(employee);
        }

        public ActionResult List()
        {
            var employeesList = new Employees().CreateEmployees();
            return View(employeesList);
        }
    }
}
