using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* We can pass data to views with ViewBag object */
            /* The .Countries is a dynamic variable. We can access it in the view */
            /*  */
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada",
            };

            return View();
        }
    }
}
