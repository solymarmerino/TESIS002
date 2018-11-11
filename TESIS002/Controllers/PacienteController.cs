using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Models;

namespace TESIS002.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Listar(string nombrePaciente)
        {
			var ListaPaciente = new List<Paciente>
			{
				new Paciente(){ IdPaciente =1, NombrePaciente="JUAN", CedulaPaciente =1111111111, HistoriaClinicaPaciente =99999999, },
				new Paciente(){ IdPaciente =1, NombrePaciente="PEPE", CedulaPaciente =1111111112, HistoriaClinicaPaciente =99999990, },
				new Paciente(){ IdPaciente =1, NombrePaciente="ROSA", CedulaPaciente =1111111113, HistoriaClinicaPaciente =99999991, },
				new Paciente(){ IdPaciente =1, NombrePaciente="LUCIA",CedulaPaciente =1111111114, HistoriaClinicaPaciente =99999992,}
			};

			var resultado = ListaPaciente.Where(X => X.NombrePaciente == nombrePaciente).FirstOrDefault();
			return View(resultado);
		}
        public ActionResult Ingresar()
        {
            return View();
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