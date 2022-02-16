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

        public ActionResult Edit (int id)
        {
            Nouvelle nouvelle = DB.Nouvelles.Find(id);
            return View(nouvelle);
        }

        [HttpPost]
        public ActionResult Edit (Nouvelle nouvelle)
        {
            DB.UpdateNouvelle(nouvelle);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete (int id)
        {
            Nouvelle nouvelle = DB.Nouvelles.Find(id);
            return View(nouvelle);
        }

        [HttpPost]
        public ActionResult Delete (Nouvelle nouvelle)
        {
            DB.RemoveNouvelle(nouvelle);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details (int id)
        {
            Nouvelle nouvelle = DB.Nouvelles.Find(id);
            return View(nouvelle);
        }

    }
}