using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Models;
using TESIS002.Object;

namespace TESIS002.Controllers
{
    public class CitaController : Controller
    {
        ListasPaciente listasPaciente = new ListasPaciente();
        ListasCitas listasCita = new ListasCitas();
        // GET: Cita
        [HttpGet]
        public ActionResult Ingresar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(CitaModel cita)
        {
            if (!string.IsNullOrEmpty(cita.IdPaciente) && !string.IsNullOrEmpty(cita.Especialidad) && !string.IsNullOrEmpty(cita.Medico) && !string.IsNullOrEmpty(cita.TipoCita))
            {
                int numeroCita = listasCita.numberOfCita() + 1;
                cita.IdCita = numeroCita.ToString();
                cita.Pagado = "NO";
                cita.Enfermeria = "NO";
                cita.Atencion = "NO";
                cita.Facturado = "NO";
                listasCita.addCita(cita);
            }
            CitaModel citaEnviar = cita;
            citaEnviar.Paciente = listasPaciente.searchPaciente(cita.IdPaciente);
            citaEnviar.ListaCita = listasCita.getListaCitaPaciente(cita.IdPaciente);
            return View(citaEnviar);
        }

        public ActionResult Listar()
        {
            return View(listasCita.getListaCitaConPaciente());
        }

        public ActionResult CambiarEstado(CitaModel cita)
        {
            CitaModel citaEnviar = listasCita.getCita(cita.IdCita);
            if (!string.IsNullOrEmpty(cita.Pagado))
            {
                citaEnviar.Pagado = cita.Pagado;
            }
            if (!string.IsNullOrEmpty(cita.Facturado))
            {
                citaEnviar.Facturado = cita.Facturado;
            }
            listasCita.actualizarCita(citaEnviar);

            List<CitaModel> citasListar = listasCita.getListaCitaConPaciente();

            return RedirectToAction("Listar", "Cita");
        }

        public ActionResult CambiarAPagado(CitaModel cita)
        {
            CitaModel citaEnviar = cita;
            return View("Listar", listasCita.getListaCitaConPaciente());
        }

        public ActionResult CambiarAFacturado(string IdCita)
        {
            return View("Listar", listasCita.getListaCitaConPaciente());
        }
    }
}