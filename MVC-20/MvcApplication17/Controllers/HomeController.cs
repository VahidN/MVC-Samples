using System.Web.Mvc;
using MvcApplication17.Models;

namespace MvcApplication17.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(string sort, string sortdir, int? page = 1)
        {
            var list = EmployeeDataSource.CreateEmployees();
            var model = new RptViewModel { EmployeesList = list };
            return View(model);
        }
    }
}