using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class FirstMVCController : Controller
    {
        // GET: FirstMVC
        public ActionResult SayHello()
        {
            return View("HelloView");
        }

        public void DoSomeThing()
        {
            Response.Write("<script>alert('DoSomeThing')</script>");
        }
    }
}