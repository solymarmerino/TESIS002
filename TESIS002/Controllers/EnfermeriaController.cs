using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Models;
using TESIS002.Object;

namespace TESIS002.Controllers
{    
    public class EnfermeriaController : Controller
    {
        ListasEnfermeria listaEnfermeria = new ListasEnfermeria();

        public ActionResult Listar()
        {
            return View();
        }

        // GET: Enfermeria
        public ActionResult IngresarSignosVitales(string id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarSignosVitales(SignoVital signo)
        {
            int numeroSigno = listaEnfermeria.numberOfSigno() + 1;
            signo.IdSignoVital = numeroSigno.ToString();
            this.listaEnfermeria.addSignoVital(signo);
            return RedirectToAction("Listar", "Cita");
        }
    }
}