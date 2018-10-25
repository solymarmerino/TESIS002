using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TESIS002.Controllers
{
    public class ContabilidadController : Controller
    {
        // GET: Contabilidad
        public ActionResult Ingreso()
        {
            return View();
        }

        public ActionResult Egreso()
        {
            return View();
        }

        public ActionResult Informe()
        {
            return View();
        }

        public ActionResult PagoPersonal()
        {
            return View();
        }
    }
}