using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(ViewModels.AuthLogin form)
        {

            if (!ModelState.IsValid) // if view model does not pass checks for annotations 
                return View(form);

            if(form.Username != "rainbow") // usually a database check 
            {
                ModelState.AddModelError("Username", "Username not valid");
                return View(form);
            }

            return Content("Valid");
        }
    }
}