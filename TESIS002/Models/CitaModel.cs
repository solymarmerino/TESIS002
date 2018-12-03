using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Models
{
    public class CitaModel
    {
        public string IdCita { get; set; }
        public string IdPaciente { get; set; }
        public string Especialidad { get; set; }
        public string Medico { get; set; }
        public string TipoCita { get; set; }                          
        public PacienteModel Paciente { get; set; }
        public List<CitaListaModel> ListaCita { get; set; }
    }
}