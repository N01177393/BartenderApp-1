using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BartenderApp.Controllers
{
    public class BartenderController : Controller
    {
        //Homepage
        public ActionResult Home()
        {
            return View();
        }

        //Drink menu
        public ActionResult Menu()
        {
            return View();
        }
    }
}