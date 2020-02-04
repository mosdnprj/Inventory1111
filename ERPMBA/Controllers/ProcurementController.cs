using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERPMBA.Controllers
{
    public class ProcurementController : Controller
    {
        //
        // GET: /Procorment/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexResult()
        {
            return PartialView("IndexResult");

        }



    }
}
