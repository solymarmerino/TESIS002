using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Models
{
	public class Paciente
	{
		public int IdPaciente { get; set; }
		public string NombrePaciente { get; set; }
		public int CedulaPaciente { get; set; }
		public int HistoriaClinicaPaciente { get; set; }
	}
}