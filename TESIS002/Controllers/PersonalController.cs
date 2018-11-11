using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Models;
using TESIS002.Object;

namespace TESIS002.Controllers
{
    public class PersonalController : Controller
    {
        Listas listas = new Listas();
        // GET: Personal
        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(PersonalModel empleado)
        {
            if (!string.IsNullOrEmpty(empleado.NombrePersonal) && !string.IsNullOrEmpty(empleado.IdPersonal) && !string.IsNullOrEmpty(empleado.TelefonoPersonal) && !string.IsNullOrEmpty(empleado.CargoPersonal))
            {
                this.listas.addListaPersonal(empleado);
                return RedirectToAction("Listar","Personal");
            }
            else
            {
                return View(empleado);
            }
            
        }

        public ActionResult Listar()
        {
            return View(this.listas.getListaPersonal());
        }

        public ActionResult Modificar()
        {
            return View();
        }
    }
}