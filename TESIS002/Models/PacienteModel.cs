﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Models
{
	public class PacienteModelBK
	{
		public int IdPaciente { get; set; }
		public int HistoriaClinicaPaciente { get; set; }
		public string NombrePaciente { get; set; }
		public string CedulaPaciente { get; set; }
		public string DireccionPaciente { get; set; }
		public string TelefonoPaciente { get; set; }
		public DateTime FechaNacimientoPaciente { get; set; }
		public int GeneroPaciente { get; set; }
		public int EstadoCivilPaciente { get; set; }
		public int TipoSangrePaciente { get; set; }
		public string NombreContactoEmergenciaPaciente { get; set; }
		public string AfinidadContactoEmergenciaPaciente { get; set; }
		public string TelefonoContatoEmergenciaPaciente { get; set; }
		public string AntecedentesPaciente { get; set; }
	}
}