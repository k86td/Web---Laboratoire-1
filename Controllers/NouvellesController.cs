using System;
using System.Collections.Generic;
using Laboratoire_1.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratoire_1.Controllers
{
    public class NouvellesController : Controller
    {
        private NouvellesDbEntities DB = new NouvellesDbEntities();

        // GET: Nouvelles
        public ActionResult Index()
        {
            return View(DB.Nouvelles);
        }
    }
}