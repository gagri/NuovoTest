using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Models.User user)
        {
            string email = user.email;
            string password = user.password;

            if(user.email.Equals("test", StringComparison.InvariantCultureIgnoreCase))
                ViewBag.Message = "Benvenuto test!!!";
            else
                ViewBag.Message = "Username o password errati!!!";

            return View("Contact");
        }
    }
}