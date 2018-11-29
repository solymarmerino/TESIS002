using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Models;
using TESIS002.Object;

namespace TESIS002.Controllers
{
	public class PacienteController : Controller
	{
		ListasPaciente listas = new ListasPaciente();
		// GET: Paciente

		public ActionResult Listar()
        {
			return View();
		}
        public ActionResult Ingresar()
        {
            return View();
        }
		/*lalalallal*/
		[HttpPost]
		public ActionResult Ingresar(PacienteModel paciente)
		{
			if (!string.IsNullOrEmpty(paciente.NombrePaciente) && 
				!string.IsNullOrEmpty(paciente.CedulaPaciente) && 
				!string.IsNullOrEmpty(paciente.DirecciónPaciente) && 
				!string.IsNullOrEmpty(paciente.TelefonoPaciente) && 
				!string.IsNullOrEmpty(paciente.FechaNacimientoPaciente) && 
				!string.IsNullOrEmpty(paciente.GeneroPaciente) &&
				!string.IsNullOrEmpty(paciente.EstadoCivilPaciente) &&
				!string.IsNullOrEmpty(paciente.TipoSangrePaciente) &&
				!string.IsNullOrEmpty(paciente.NombreContactoEmergenciaPaciente) &&
				!string.IsNullOrEmpty(paciente.AfinidadContactoEmergenciaPaciente) &&
				!string.IsNullOrEmpty(paciente.TipoSangrePaciente) &&
				!string.IsNullOrEmpty(paciente.AntecedentesPaciente))
			{
				int numeroPacientes = listas.numberOfPaciente() + 1;
				paciente.IdPaciente = numeroPacientes.ToString();
				this.listas.addListaPaciente(paciente);
				paciente = listas.searchPacienteCedula(paciente.CedulaPaciente);
				return View(paciente);
			}
			else
			{
				return View(paciente);
			}
		}

		public ActionResult Mostrar()
        {
            return View();
        }

        public ActionResult Actualizar()
        {
            return View();
        }
    }
}