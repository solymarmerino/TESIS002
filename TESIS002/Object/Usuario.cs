using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Object
{
    public class Usuario
    {
        private string userName;
        private string userPass;

        public string UserName { get; set; }
        public string UserPass { get; set; }


        public string GetUserAdmin()
        {
            return "admin";
        }

        public string GetTypeUser()
        {
            return "admin";
        }
    }
}