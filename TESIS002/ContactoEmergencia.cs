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
    
    public partial class ContactoEmergencia
    {
        public int IdContactoEmergencia { get; set; }
        public string NombreContactoEmergencia { get; set; }
        public string AfinidadContactoEmergencia { get; set; }
        public int TelefonoContactoEmergencia { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}