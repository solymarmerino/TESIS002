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
    
    public partial class Enfermedad
    {
        public int IdEnfermedad { get; set; }
        public string NombreEnfermedad { get; set; }
        public string CIE10Enfermedad { get; set; }
    
        public virtual Diagnostico Diagnostico { get; set; }
    }
}
