using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaqueteTuristicoWeb.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Grupo S.O.S.";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
