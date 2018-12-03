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
			return View(this.listas.getListaPaciente());
		}
		[HttpGet]
		public ActionResult Listar(string tipoParametro, string parametroBusqueda)
		{
	
			if (!string.IsNullOrEmpty(parametroBusqueda) && tipoParametro.Equals("Nombre"))
			{
				PacienteModel paciente = this.listas.buscarPacienteNombre(parametroBusqueda);
				return View(paciente);
			}
			if (!string.IsNullOrEmpty(parametroBusqueda) && tipoParametro.Equals("Cedula"))
			{
				PacienteModel paciente = this.listas.searchPaciente(parametroBusqueda);
				return View(paciente);
			}
			if (!string.IsNullOrEmpty(parametroBusqueda) && tipoParametro.Equals("HCPaciente"))
			{
				PacienteModel paciente = this.listas.buscarPacienteHCPaciente(parametroBusqueda);
				return View(paciente);
			}

			return View(this.listas.getListaPaciente());
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
				!string.IsNullOrEmpty(paciente.DireccionPaciente) && 
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
                //return View(paciente);
                return RedirectToAction("Listar", "Paciente");
            }
			else
			{
				return View(paciente);
			}
		}

        [HttpPost]
		public ActionResult Mostrar(string idPaciente)
        {
            PacienteModel paciente = this.listas.searchPaciente(idPaciente);
            return View(paciente);
        }

		[HttpPost]
		public ActionResult Actualizar(PacienteModel paciente)
		{
			PacienteModel pacienteResultado = this.listas.searchPaciente(paciente.IdPaciente);
			return View(pacienteResultado);
		}

		[HttpPost]
		public ActionResult ActualizarPaciente(PacienteModel paciente)
		{

			if (!string.IsNullOrEmpty(paciente.NombrePaciente) &&
				!string.IsNullOrEmpty(paciente.CedulaPaciente) &&
				!string.IsNullOrEmpty(paciente.DireccionPaciente) &&
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
				this.listas.modificarPaciente(paciente);
				return RedirectToAction("Listar", "Paciente");
			}
			else
			{
				return RedirectToAction("Listar", "Paciente");
			}
		}
	}
}