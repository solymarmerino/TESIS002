using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TESIS002.Controllers
{
    public class EnfermeriaController : Controller
    {
        // GET: Enfermeria
        public ActionResult IngresarSignosVitales()
        {
            return View();
        }
    }
}