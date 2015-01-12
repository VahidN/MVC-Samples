using System.Web.Mvc;
using MvcApplication14.Models;

namespace MvcApplication14.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        //[RequireHttps]
        public ActionResult CreateBlogPost()
        {
            var post = new BlogPost();
            return View(post);
        }
        
        [HttpPost]
        //[ValidateInput(false)]
        [ValidateAntiForgeryToken()]
        public ActionResult CreateBlogPost(BlogPost post)
        {
            if (this.ModelState.IsValid)
            { 
                //todo: add data
                RedirectToAction("Index");
            }
            return View(post);
        }
    }
}
