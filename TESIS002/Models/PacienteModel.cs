using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Models
{
	public class PacienteModel
	{
		public string IdPaciente { get; set; }
		public string HistoriaClinicaPaciente { get; set; }
		public string NombrePaciente { get; set; }
		public string CedulaPaciente { get; set; }
		public string DireccionPaciente { get; set; }
		public string TelefonoPaciente { get; set; }
		public string FechaNacimientoPaciente { get; set; }
		public string GeneroPaciente { get; set; }
		public string EstadoCivilPaciente { get; set; }
		public string TipoSangrePaciente { get; set; }
		public string NombreContactoEmergenciaPaciente { get; set; }
		public string AfinidadContactoEmergenciaPaciente { get; set; }
		public string TelefonoContatoEmergenciaPaciente { get; set; }
		public string AntecedentesPaciente { get; set; }
	}
}