using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Models;

namespace TESIS002.Controllers
{
    public class HistoriaClinicaController : Controller
    {
        // GET: HistoriaClinica
        public ActionResult Mostrar()
        {
            return View();
        }

        public ActionResult MostrarFrecuenciaCardiaca()
        {
            return View();
        }

        public ActionResult MostrarFrecuenciaRespiratoria()
        {
            return View();
        }

        public ActionResult MostrarIndiceMasaCorporal()
        {
            return View();
        }

        public ActionResult MostrarPeso()
        {
            return View();
        }

        public ActionResult MostrarTalla()
        {
            return View();
        }

        public ActionResult MostrarTemperatura()
        {
            return View();
        }

        public ActionResult MostrarCertificadoMedico()
        {
            return View();
        }

        public ActionResult MostrarDiagnosticoPrevio()
        {
            return View();
        }
        public ActionResult MostrarPrecionArterial()
        {
            return View();
        }

        public ActionResult IngresarDiagnostico(DiagnosticoModel diagnostico)
        {

            return View();
        }
    }
}