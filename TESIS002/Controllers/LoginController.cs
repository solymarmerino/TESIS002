using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Object;

namespace TESIS002.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            Session["login"] = "false";
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario user)
        {
            if (!string.IsNullOrEmpty(user.UserName) && user.UserName.Equals(user.GetUserAdmin()))
            {
                Session["login"] = "true";
                Session["typeUser"] = user.GetTypeUser();
                return RedirectToAction("Listar","Cita");
            }
            else
            {
                return View();
            }
        }
    }
}