using System;
using System.Linq;
using System.Web.Mvc;
using MvcApplication7.Models;
using MvcApplication7.Binders;

namespace MvcApplication7.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var usersList = new Users().CreateInMemoryDataSource();
            return View(usersList); // Shows the Index view.
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = new Users().CreateInMemoryDataSource().FirstOrDefault(x => x.Id == id);
            if (user == null)
                return View("Error");
            return View(user); // Shows the Details view.
        }

        [HttpGet]
        public ActionResult Create()
        {
            var user = new User { AddDate = DateTime.Now };
            return View(user); // Shows the Create view.
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            ModelState.Remove("Name"); // به روز رساني مقدار يك خاصيت در حالت ويژه ارسال به سرور
            user.Name = "new name";
            return View(user);
            //if (this.ModelState.IsValid)
            //{
            //    // todo: Add record                
            //    return RedirectToAction("Index");
            //}
            //return View(user); // Shows the Create view again.
        }


        /*public ActionResult Create([ModelBinder(typeof(PersianDateModelBinder))] User user)
        {

        }*/

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = new Users().CreateInMemoryDataSource().FirstOrDefault(x => x.Id == id);
            if (user == null)
                return View("Error");
            return View(user); // Shows the Edit view.
        }

        [HttpPost]
        //public ActionResult Edit([Bind(Include = "Name, Password")] User user)
        public ActionResult Edit([Bind(Exclude = "IsAdmin")] User user)
        {
            if (this.ModelState.IsValid)
            {
                // todo: Edit record
                return RedirectToAction("Index");
            }
            return View(user); // Shows the Edit view again.
        }

        /*[HttpPost]
        public ActionResult Edit()
        {
            var user = new User();
            if (TryUpdateModel(user, includeProperties: new[] { "Name", "Password" }))
            {
                // todo: Edit record
                return RedirectToAction("Index");
            }
            return View(user); // Shows the Edit view again.
        }*/

        [HttpPost]
        public ActionResult Delete(int id)
        {
            // todo: Delete record
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Upload()
        {
            return View(); // Shows the upload page
        }

        [HttpPost]
        public ActionResult Upload(System.Web.HttpPostedFileBase file)
        {
            string filename = Server.MapPath("~/files/somename.ext");
            file.SaveAs(filename);
            return RedirectToAction("Index");
        }

        public ActionResult Download()
        {
            return File(Server.MapPath("~/Views/test.txt"), "text/txt");
        }
    }
}
