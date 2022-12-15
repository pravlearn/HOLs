using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String id)
        {
            if (id == null)
            {
                return Content("<h1> This is a demo of ContentResult</h1>");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1> This is ademo of ContentResult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1> This is a demo of ContentResult</h1>", "text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1> This is a demo of ContentResult</h1>", "text/xml");
            }
            return Content("Invalid content type");
           
        }

        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"e:\lighthouse.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"\lighthouse.jpg", "image/jpg", "default.jpg");

           
        }

        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "xml" });

            
        }
         public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}