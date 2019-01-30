using HumaneSociety.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumaneSociety.Controllers
{
    public class PetController : Controller
    {
        private PetDBContext db = new PetDBContext();

        // GET: Pet
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }

        //GET Pet Create
        public ActionResult Create()
        {
            return View();
        }
        // POST Pet Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pets pet)
        {
            if (ModelState.IsValid)
            {
                db.Pets.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        //GET Pet Edit
        public ActionResult Edit(int id)
        {
            Pets pets = db.Pets.Find(id);
            if(pets == null)
            {
                return HttpNotFound();
            }
            return View(pets);
        }

        //POST Pet Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pets pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        //GET Pet Delete
        public ActionResult Delete(int id)
        {
            Pets pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }
        //POST Pet Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pets pet = db.Pets.Find(id);
            db.Pets.Remove(pet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}