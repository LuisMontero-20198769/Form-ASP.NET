using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITLA.Controllers
{
    public class CampusController : Controller
    {
        // GET: Campus

        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Formulario()
        {
            return View();
        }
    }
}