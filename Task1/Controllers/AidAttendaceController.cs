using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class AidAttendaceController : Controller
    {
        // GET: AidAttendace
        [HttpGet]
        public ActionResult AidAndAttendance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AidAndAttendance(AidAndAttendance aidAndAttendance )
        {
            
            //if (ModelState.IsValid)
           // {

            //}
            return View();
        }
    }
}