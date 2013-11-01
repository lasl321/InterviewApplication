using System.Diagnostics;
using System.Web.Mvc;

namespace InterviewApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HandleForm()
        {
            var username = Request["Username"];
            var password = Request["Password"];

            Trace.WriteLine("username: " + username);
            Trace.WriteLine("password: " + password);

            if (username == "valid" && password == "valid")
            {
                return RedirectToAction("LoggedIn");
            }

            return RedirectToAction("LoginFailure");
        }

        public ActionResult LoggedIn()
        {
            return View();
        }

        public ActionResult LoginFailure()
        {
            return View();
        }
    }
}