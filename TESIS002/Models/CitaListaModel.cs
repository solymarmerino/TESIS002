using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Models
{
    public class CitaListaModel
    {
        public string IdCita { get; set; }
        public string IdPaciente { get; set; }
        public string Especialidad { get; set; }
        public string Medico { get; set; }
        public string TipoCita { get; set; }                          
    }
}