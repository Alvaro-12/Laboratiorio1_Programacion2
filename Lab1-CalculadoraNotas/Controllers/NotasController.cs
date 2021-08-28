using Lab1_CalculadoraNotas.Models;
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
        public ActionResult CalcularN(string nombre, float lab1, float lab2, float lab3, float parcial1
                                     , float parcial2, float parcial3)
        {
            using (EstudianteEntities5 datos = new EstudianteEntities5())
            {
                TblNotasEstudiante estudianteN = new TblNotasEstudiante();

                estudianteN.Nombre = nombre;
                estudianteN.Lab1 = lab1;
                estudianteN.Lab2 = lab2;
                estudianteN.Lab3 = lab3;
                estudianteN.Parcial1 = parcial1;
                estudianteN.Parcial2 = parcial2;
                estudianteN.Parcial3 = parcial3;

               double periodo1 = (lab1 * 0.4)+(parcial1 * 0.6);
                double periodo2 = (lab2 * 0.4) + (parcial2 * 0.6);
                double periodo3 = (lab3 * 0.4) + (parcial3 * 0.6);

                estudianteN.Periodo1 = periodo1;
                estudianteN.Periodo2 = periodo2;
                estudianteN.Periodo3 = periodo3;
                estudianteN.NotaFianl = (periodo1 + periodo2 + periodo3) / 3;

                datos.TblNotasEstudiante.Add(estudianteN);
                datos.SaveChanges();

            }

                return Redirect("/Notas/Resultado/");
        }

        public ActionResult Resultado()
        {
            using (EstudianteEntities5 notas = new EstudianteEntities5())
            {
                TblNotasEstudiante lista = new TblNotasEstudiante();

                var NOTAS = notas.Set<TblNotasEstudiante>().OrderByDescending(t => t.Id).FirstOrDefault();
                return View("Resultado");
            }
                
        }

        public ActionResult Registro()
        {
            return View();
        }
    }
}