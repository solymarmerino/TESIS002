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
        Validacion validacion = new Validacion();
        // GET: Personal
        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(PersonalModel empleado)
        {
            if (!string.IsNullOrEmpty(empleado.NombrePersonal) && !string.IsNullOrEmpty(empleado.CedulaPersonal) && !string.IsNullOrEmpty(empleado.TelefonoPersonal) && !string.IsNullOrEmpty(empleado.CargoPersonal) && !string.IsNullOrEmpty(empleado.UsuarioPersonal) && !string.IsNullOrEmpty(empleado.ContrasenaPersonal) && validacion.ValidarCedula(empleado.CedulaPersonal))
            {
                int numeroEmpleados = listas.numberOfPersonal() + 1;
                empleado.IdPersonal = numeroEmpleados.ToString();
                this.listas.addListaPersonal(empleado);
                empleado = listas.searchPersonalCedula(empleado.CedulaPersonal);
                return View(empleado);
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

        [HttpPost]
        public ActionResult Modificar(string idPersonal)
        {
            return View(this.listas.searchPersonal(idPersonal));
        }

        [HttpPost]
        public ActionResult ModificarPersonal(PersonalModel empleado)
        {
            if (!string.IsNullOrEmpty(empleado.NombrePersonal) && !string.IsNullOrEmpty(empleado.IdPersonal) && !string.IsNullOrEmpty(empleado.TelefonoPersonal) && !string.IsNullOrEmpty(empleado.CargoPersonal))
            {
                this.listas.modifyPersonal(empleado);
                return RedirectToAction("Listar", "Personal");
            }
            else
            {
                //return RedirectToAction("Modificar", "Personal", new { idPersonal = empleado.IdPersonal});
                return RedirectToAction("Listar", "Personal");
            }
        }

        public ActionResult IngresarServicio(ServicioPersonalModel servicoPersonal)
        {
            return RedirectToAction("Listar", "Personal");
        }
    }
}