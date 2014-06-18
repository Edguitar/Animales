using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAnimales.Models;

namespace WebAnimales.Controllers
{
    public class AnimalesController : Controller
    {
        private WebAnimalesContext db = new WebAnimalesContext();

        //
        // GET: /Animales/

        public ActionResult Index()
        {
            return View(db.Animales.ToList());
        }

        //
        // GET: /Animales/Details/5

        public ActionResult Details(int id = 0)
        {
            Animales animales = db.Animales.Find(id);
            if (animales == null)
            {
                return HttpNotFound();
            }
            return View(animales);
        }

        //
        // GET: /Animales/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Animales/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Animales animales)
        {
            if (ModelState.IsValid)
            {
                db.Animales.Add(animales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(animales);
        }

        //
        // GET: /Animales/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Animales animales = db.Animales.Find(id);
            if (animales == null)
            {
                return HttpNotFound();
            }
            return View(animales);
        }

        //
        // POST: /Animales/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Animales animales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animales);
        }

        //
        // GET: /Animales/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Animales animales = db.Animales.Find(id);
            if (animales == null)
            {
                return HttpNotFound();
            }
            return View(animales);
        }

        //
        // POST: /Animales/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Animales animales = db.Animales.Find(id);
            db.Animales.Remove(animales);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}