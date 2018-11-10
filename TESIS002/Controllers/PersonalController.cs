using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESIS002.Object;

namespace TESIS002.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(Personal employee)
        {
            if (!string.IsNullOrEmpty(employee.EmployeeName) && !string.IsNullOrEmpty(employee.EmployeeID) && !string.IsNullOrEmpty(employee.EmployeePhone) && !string.IsNullOrEmpty(employee.EmployeePosition))
            {
                return RedirectToAction("Listar","Personal");
            }
            else
            {
                return View(employee);
            }
            
        }

        public ActionResult Listar()
        {
            return View();
        }

        public ActionResult Modificar()
        {
            return View();
        }
    }
}