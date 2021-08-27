using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_CalculadoraNotas.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult Index()
        {

            
            return View();
        }
        public ActionResult Resultado()
        {


            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }
    }
}