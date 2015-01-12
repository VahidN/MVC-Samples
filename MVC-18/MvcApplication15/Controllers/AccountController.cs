using System.Web.Mvc;
using System.Web.Security;
using MvcApplication15.Models;

namespace MvcApplication15.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult LogOn(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //remember me
            {
                if (shouldRedirect(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                return Redirect(FormsAuthentication.DefaultUrl);
            }

            return View(); // show the login page
        }

        [HttpGet]
        public void LogOut()
        {
            FormsAuthentication.SignOut();
        }

        private bool shouldRedirect(string returnUrl)
        {
            // it's a security check
            return !string.IsNullOrWhiteSpace(returnUrl) &&
                                Url.IsLocalUrl(returnUrl) &&
                                returnUrl.Length > 1 &&
                                returnUrl.StartsWith("/") &&
                                !returnUrl.StartsWith("//") &&
                                !returnUrl.StartsWith("/\\");
        }

        [HttpPost]
        public ActionResult LogOn(Account loginInfo, string returnUrl)
        {
            if (this.ModelState.IsValid)
            {
                if (loginInfo.Username == "Vahid" && loginInfo.Password == "123")
                {
                    FormsAuthentication.SetAuthCookie(loginInfo.Username, loginInfo.RememberMe);
                    if (shouldRedirect(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    FormsAuthentication.RedirectFromLoginPage(loginInfo.Username, loginInfo.RememberMe);
                }
            }
            this.ModelState.AddModelError("", "The user name or password provided is incorrect.");
            ViewBag.Error = "Login faild! Make sure you have entered the right user name and password!";
            return View(loginInfo);
        }
    }
}
