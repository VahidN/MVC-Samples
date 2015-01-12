using System;
using System.Web.Mvc;
using MvcApplication8.Models;

namespace MvcApplication8.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult EmployeeList()
        {
            var list = new Employees().CreateEmployees();
            return View(list);
        }

        public ActionResult Create()
        {
            var employee = new Employee { AddDate = DateTime.Now };
            return View(employee);
        }               
    }
}
