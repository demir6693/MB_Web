using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MB_Web.Controllers
{
    
    public class HomeController : Controller
    {   
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mesecni";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Godisnji";

            return View();
        }

        public ActionResult korisnici()
        {
            ViewBag.Message = "Korisnici";

            return View();
        }
    }
}