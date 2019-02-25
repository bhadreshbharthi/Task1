using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class SleepApneaController : Controller
    {
        // GET: SleepApnea
        public ActionResult SleepApneaForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SleepApneaForm(SleepApneaModel sleepApneaModel)
        {

            return View();
        }

    }
}