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

        [HttpPost]
        public ActionResult CalcularN(string Nombre, double lab1, double lab2,double lab3, double Par1, double par2, double par3)
        {
            using (EstudianteEntities5 datos = new EstudianteEntities5())
            {
                TblNotasEstudiante estudianteN = new TblNotasEstudiante();

                estudianteN.Nombre = Nombre;
                estudianteN.Lab1 = lab1;
                estudianteN.Lab2 = lab2;
                estudianteN.Lab3 = lab3;
                estudianteN.Parcial1 = Par1;
                estudianteN.Parcial2 = par2;
                estudianteN.Parcial3 = par3;

                double periodo1 = (lab1 * 0.4) + (Par1 * 0.6);
                double periodo2 = (lab2 * 0.4) + (par2 * 0.6);
                double periodo3 = (lab3 * 0.4) + (par3 * 0.6);

                estudianteN.Periodo1 = periodo1;
                estudianteN.Periodo2 = periodo2;
                estudianteN.Periodo3 = periodo3;
                estudianteN.NotaFianl = (periodo1 + periodo2 + periodo3) / 3;

                datos.TblNotasEstudiante.Add(estudianteN);
                datos.SaveChanges();

            }
                return Redirect("/Notas/Resultado");
        }

        public ActionResult Resultado()
        {
            using (EstudianteEntities5 notas = new EstudianteEntities5())
            {
                TblNotasEstudiante lista = new TblNotasEstudiante();

                var resultado = notas.Set<TblNotasEstudiante>().OrderByDescending(t => t.Id).FirstOrDefault();
               
                return View(resultado);
            }
                
        }

        public ActionResult Registro()
        {
            using (EstudianteEntities5 nt = new EstudianteEntities5())
            {
                var Registro = nt.TblNotasEstudiante.ToList();
                return View(Registro);
            }
        }
    }
}