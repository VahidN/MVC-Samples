using System.Linq;
using System.Web.Mvc;
using MvcApplication18.Models;
using System;

namespace MvcApplication18.Controllers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AjaxOnlyAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                base.OnActionExecuting(filterContext);
            }
            else
            {
                throw new InvalidOperationException("This operation can only be accessed via Ajax requests");
            }
        }
    }

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] //for IE-8        
        public ActionResult EmployeeInfo(int? id)
        {
            if (!Request.IsAjaxRequest())
                return View("Error");

            if (!id.HasValue)
                return View("Error");

            var list = EmployeeDataSource.CreateEmployees();
            var data = list.Where(x => x.Id == id.Value).FirstOrDefault();
            if (data == null)
                return View("Error");

            return PartialView(viewName: "_EmployeeInfo", model: data);
        }


        [HttpPost] //for IE-8        
        public ActionResult EmployeeInfoData(int? id)
        {
            if (!Request.IsAjaxRequest())
                return Json(false);

            if (!id.HasValue)
                return Json(false);

            var list = EmployeeDataSource.CreateEmployees();
            var data = list.Where(x => x.Id == id.Value).FirstOrDefault();
            if (data == null)
                return Json(false);

            return Json(data);
        }

        [HttpPost] //for IE-8        
        public ActionResult SearchEmployeeInfo(string data)
        {
            if (!Request.IsAjaxRequest())
                return Content(string.Empty);

            if (string.IsNullOrWhiteSpace(data))
                return Content(string.Empty);

            var employeesList = EmployeeDataSource.CreateEmployees();
            var list = employeesList.Where(x => x.Name.Contains(data)).ToList();
            if (list == null || !list.Any())
                return Content(string.Empty);

            return PartialView(viewName: "_SearchEmployeeInfo", model: list);
        }
    }
}
