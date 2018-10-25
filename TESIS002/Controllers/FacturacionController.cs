using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TESIS002.Controllers
{
    public class FacturacionController : Controller
    {
        // GET: Facturacion
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Anular()
        {
            return View();
        }
    }
}