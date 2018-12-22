using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Control_de_clientes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mi sistema de control";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Forma de contactarme";

            return View();
        }
    }
}