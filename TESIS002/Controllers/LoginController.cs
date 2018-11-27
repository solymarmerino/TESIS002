using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Models;
using TESIS002.Object;

namespace TESIS002.Controllers
{
    public class LoginController : Controller
    {
        Listas lista = new Listas();
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            Session["login"] = "false";
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuarioModel usuario)
        {
            PersonalModel empleado = lista.searchPersonalUsuario(usuario.NombreUsuario);
            if (!string.IsNullOrEmpty(usuario.NombreUsuario) && !string.IsNullOrEmpty(usuario.ContrasenaUsuario) &&  empleado.UsuarioPersonal.Equals(usuario.NombreUsuario) && empleado.ContrasenaPersonal.Equals(usuario.ContrasenaUsuario))
            {
                Session["login"] = "true";
                Session["typeUser"] = empleado.CargoPersonal;
                return RedirectToAction("Lobby","Login");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Lobby()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["login"] = "false";
            Session["typeUser"] = "";
            return RedirectToAction("Login", "Login");
        }
    }
}