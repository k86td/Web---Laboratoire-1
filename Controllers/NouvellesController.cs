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
        private readonly NouvellesDbEntities DB = new NouvellesDbEntities();

        public ActionResult Index()
        {
            return View(DB.Nouvelles);
        }

        public ActionResult Create ()
        {
            return View(new Nouvelle());
        }

        [HttpPost]
        public ActionResult Create (Nouvelle nouvelle)
        {
            if (ModelState.IsValid)
                DB.AddNouvelle(nouvelle);

            return RedirectToAction("Index");
        }

    }
}