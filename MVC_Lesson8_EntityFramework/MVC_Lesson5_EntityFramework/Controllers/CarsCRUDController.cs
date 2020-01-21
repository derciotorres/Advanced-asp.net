using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Lesson5_EntityFramework.Models;
using System.Web.Helpers;       // Added for WebImage function

namespace MVC_Lesson5_EntityFramework.Controllers
{
    public class CarsCRUDController : Controller
    {
        private CarFactory db = new CarFactory();

        // GET: CarsCRUD
        public ActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        // GET: CarsCRUD/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: CarsCRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsCRUD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Car_ID,Model,MaxSpeed")] Car car)
        {
            //If the data entry validation code is correct, add the car, then move to the index (with new Car listed)
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);   //Else, stay in this view and show the error message.
        }

        // GET: CarsCRUD/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: CarsCRUD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Car_ID,Model,MaxSpeed")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        // GET: CarsCRUD/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: CarsCRUD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Picture(int id)
        {
            //Factory Instance
            var factory = new CarFactory();

            //Find car from DB based on the ID
            var car = factory.Cars.Where(p => p.Car_ID == id).FirstOrDefault();

            //If null (no mathc, get out)
            if (car == null)
            {
                return HttpNotFound();
            }

            //Else, we found a match
            // Create an image object and resize it
            var img = new WebImage(string.Format("~/Content/Images/{0}.jpg", car.ImageName));
            img.Resize(100, 100);

            //Return this image for use by other Actions/methods
            return File(img.GetBytes(), "image/jpeg");
        }


    }
}
