using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Models
{
    public class UsuarioModel
    {       
        public string NombreUsuario { get; set; }
        public string ContrasenaUsuario { get; set; }

        public string GetUsuarioAdministrador()
        {
            return "administrador";
        }

        public string GetTipoUsuario()
        {
            return "administrador";
        }
    }
}