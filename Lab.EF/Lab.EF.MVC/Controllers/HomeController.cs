using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripción de página.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacta con nuestra empresa.";

            return View();
        }
    }
}