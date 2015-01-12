using System.Web.Mvc;

namespace MvcApplication8.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult ShowMenu(string options)
        {
            return PartialView(viewName: "_ShowMenu", model: options);
        }
    }
}
