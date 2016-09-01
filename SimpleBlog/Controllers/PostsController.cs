using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController : Controller
    {   
        // needs to be public. Returns ActionResult.  Controller library has methods that construct ActionResult.
        public ActionResult Index()
        {
            return Content("hello world");
        }
    }
}