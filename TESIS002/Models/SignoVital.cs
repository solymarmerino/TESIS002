using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Models
{
    public class SignoVital
    {
        public string IdSignoVital { get; set; }
        public string IdHistoriaClinica { get; set; }
        public string Temperatura { get; set; }
        public string PrecionArterial { get; set; }
        public string Fr { get; set; }
        public string Fc { get; set; }
        public string Peso { get; set; }
        public string Talla { get; set; }
    }
}