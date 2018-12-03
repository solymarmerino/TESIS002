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
        /*public ActionResult Ingresar(string idPersonal)
        {
            if (string.IsNullOrEmpty(idPersonal))
            {
                PersonalModel empleado = listas.searchPersonal(idPersonal);
                empleado.ServicioPersonal = listas.getServicioPersonal(idPersonal);
                return View(empleado);
            }
            return View();
        }*/

        [HttpPost]
        public ActionResult Ingresar(PersonalModel empleado)
        {
            if (!string.IsNullOrEmpty(empleado.NombrePersonal) && !string.IsNullOrEmpty(empleado.CedulaPersonal) && !string.IsNullOrEmpty(empleado.TelefonoPersonal) && !string.IsNullOrEmpty(empleado.CargoPersonal) && !string.IsNullOrEmpty(empleado.UsuarioPersonal) && !string.IsNullOrEmpty(empleado.ContrasenaPersonal) && validacion.ValidarCedula(empleado.CedulaPersonal))
            {
                int numeroEmpleados = listas.numberOfPersonal() + 1;
                empleado.IdPersonal = numeroEmpleados.ToString();
                this.listas.addListaPersonal(empleado);
                empleado = listas.searchPersonalCedula(empleado.CedulaPersonal);
                empleado.ServicioPersonal = listas.getServicioPersonal(empleado.IdPersonal);
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
            PersonalModel empleado = listas.searchPersonal(idPersonal);
            empleado.ServicioPersonal = listas.getServicioPersonal(idPersonal);
            return View(empleado);
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

        [HttpPost]
        public ActionResult Servicio(ServicioPersonalModel servicoPersonal)
        {

            if (servicoPersonal.Btn.Equals("ingresar"))
            {
                listas.addServicoPersonal(servicoPersonal);
            }
            if (servicoPersonal.Btn.Equals("listarServicio"))
            {
                
            }
            if (!servicoPersonal.Btn.Equals("ingresar") && !servicoPersonal.Btn.Equals("listarServicio"))
            {
                //listas.deleteServicioPersonal(servicoPersonal.Btn);
            }

            PersonalModel empleado = listas.searchPersonal(servicoPersonal.IdPersonal);
            empleado.ServicioPersonal = listas.getServicioPersonal(servicoPersonal.IdPersonal);
            return View(empleado);
            //return RedirectToAction("Ingresar", "Personal", new { IdPersonal = servicoPersonal.IdPersonal });
        }
    }
}