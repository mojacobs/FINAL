using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoffeeSnobs.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace CoffeeSnobs.Controllers
{
    public class ReviewsController : Controller
    {
        private CoffeeSnobsDB db = new CoffeeSnobsDB();

        private static List<string> cityList = new List<string>( new [] {
            "Kingston", "Suquamish", "Poulsbo", "Bainbridge Island",
            "Silverdale", "Chico", "Bremerton", "Port Orchard", "Seabeck",
            "Gorst", "Hansville", "Keyport", "Tracyton"} );

        // GET: Reviews
        public ActionResult Index()
        {
            return View(db.Reviews.ToList());
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewId,Date,Email,Shop,City,Drink,CoffeeRating,ServRating,Return")] Review review)
        {
            if (User.Identity.IsAuthenticated)
            {
                review.Email = User.Identity.Name;
                if (ModelState.IsValid)
                {
                    db.Reviews.Add(review);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(review);
        }

        public ActionResult MyReviews(Review review)
        {
            var reviews = db.Reviews.Where(r => r.Email == User.Identity.Name);

            return View(reviews.ToList());
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewId,Date,Email,Shop,City,Drink,CoffeeRating,ServRating,Return")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // AJAX-GET: Ride/CityFill?term=value
        // Used by Create and Edit Views
        public ActionResult CityFill(string term)
        {
            // pull out the days that match what's been typed in so far
            var selectedCityValue = cityList.Where(c => term != null && c.Contains(term)).Select(c => new { value = c });

            return Json(selectedCityValue, JsonRequestBehavior.AllowGet);
        }

        private string GetCoffeeRatingDisplay(int rating)
        {
            return new string('☕', rating);
        }

        private string GetServRatingDisplay(int rating)
        {
            return new string('⭐', rating);
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
