//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TESIS002
{
    using System;
    using System.Collections.Generic;
    
    public partial class CitaMedica
    {
        public int IdCitaMedica { get; set; }
        public System.DateTime FechaCitaMedica { get; set; }
        public bool EstadoEnfermeriCItaMedica { get; set; }
        public bool EstadoAtencionEnfermeria { get; set; }
        public bool EstadoPagadoCitaMedica { get; set; }
    
        public virtual Paciente Paciente { get; set; }
        public virtual TipoCitaMedica TipoCitaMedica { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
