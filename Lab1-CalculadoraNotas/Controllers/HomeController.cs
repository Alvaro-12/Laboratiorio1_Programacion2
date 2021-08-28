using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_CalculadoraNotas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return Redirect("/Notas/Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return Redirect("/Notas/Registro");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}