using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MB_Web.Controllers
{
    public class KorisniciController : Controller
    {
        // GET: Korisnici
        public ActionResult Index()
        {
            return View();
        }
    }
}