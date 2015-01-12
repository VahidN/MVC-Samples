using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            var products = new Products();
            return View(products);
        }        
    }
}