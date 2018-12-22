using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.ConsultasBD;
using TESIS002.Models;
using TESIS002.Object;

namespace TESIS002.Controllers
{
	public class PacienteController : Controller
	{
        PacienteConsulta pacienteBD = new PacienteConsulta();
        ParametroConsulta informacion = new ParametroConsulta();
        ListasPaciente listas = new ListasPaciente();
		// GET: Paciente

		public ActionResult Listar()
        {
			//return View(this.listas.getListaPaciente());
			return View();
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
                PacienteModel paciente = this.listas.searchPacienteCedula(parametroBusqueda);
			    return View(paciente);
			}
			if (!string.IsNullOrEmpty(parametroBusqueda) && tipoParametro.Equals("HCPaciente"))
			{
				PacienteModel paciente = this.listas.buscarPacienteHCPaciente(parametroBusqueda);
				return View(paciente);
			}

            //return View(this.listas.getListaPaciente());
            return View(this.pacienteBD.listaPaciente());
        }
        public ActionResult Ingresar()
        {
            ViewData["Generos"] = this.informacion.comboBoxGenero();
            ViewData["EstadosCiviles"] = this.informacion.comboBoxEstadoCivil();
            ViewData["TiposSangre"] = this.informacion.comboBoxTipoSangre();

            return View();
        }

		[HttpPost]
		public ActionResult Ingresar(PacienteModelBK paciente)
		{
			if (!string.IsNullOrEmpty(paciente.NombrePaciente) && 
				!string.IsNullOrEmpty(paciente.CedulaPaciente) && 
				!string.IsNullOrEmpty(paciente.DireccionPaciente) && 
				!string.IsNullOrEmpty(paciente.TelefonoPaciente) && 
				paciente.FechaNacimientoPaciente != null && 
				paciente.GeneroPaciente != 0 &&
				paciente.EstadoCivilPaciente != 0 &&
				paciente.TipoSangrePaciente != 0 &&
				!string.IsNullOrEmpty(paciente.NombreContactoEmergenciaPaciente) &&
				!string.IsNullOrEmpty(paciente.AfinidadContactoEmergenciaPaciente) &&
				paciente.TipoSangrePaciente != 0 &&
				!string.IsNullOrEmpty(paciente.AntecedentesPaciente))
			{
                this.pacienteBD.ingresarPaciente(paciente);
                //int numeroPacientes = listas.numberOfPaciente() + 1;
                //paciente.IdPaciente = numeroPacientes.ToString();
                //this.listas.addListaPaciente(paciente);
                //paciente = listas.searchPacienteCedula(paciente.CedulaPaciente);
                //return View(paciente);

                ViewData["Generos"] = this.informacion.comboBoxGenero();
                ViewData["EstadosCiviles"] = this.informacion.comboBoxEstadoCivil();
                ViewData["TiposSangre"] = this.informacion.comboBoxTipoSangre();
                PacienteModelBK pacienteEnviar = this.pacienteBD.obtenerPacientePorCedula(paciente.CedulaPaciente);
                //return RedirectToAction("Listar", "Paciente");
				return View("Mostrar", paciente);
			}
			else
			{
				return View(paciente);
			}
		}

        [HttpPost]
		public ActionResult Mostrar(string idPaciente)
        {
            ViewData["Generos"] = this.informacion.comboBoxGenero();
            ViewData["EstadosCiviles"] = this.informacion.comboBoxEstadoCivil();
            ViewData["TiposSangre"] = this.informacion.comboBoxTipoSangre();
            //PacienteModel paciente = this.listas.searchPaciente(idPaciente);
            PacienteModelBK pacienteEnviar = this.pacienteBD.obtenerPaciente(idPaciente);
            return View(pacienteEnviar);
        }

		[HttpPost]
		public ActionResult Actualizar(string idPaciente)
		{
            ViewData["Generos"] = this.informacion.comboBoxGenero();
            ViewData["EstadosCiviles"] = this.informacion.comboBoxEstadoCivil();
            ViewData["TiposSangre"] = this.informacion.comboBoxTipoSangre();
            PacienteModelBK pacienteEnviar = this.pacienteBD.obtenerPaciente(idPaciente);
            return View(pacienteEnviar);
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
                //return RedirectToAction("Listar", "Paciente");
                return View("Mostrar",paciente);
			}
			else
			{
				return RedirectToAction("Listar", "Paciente");
			}
		}
	}
}