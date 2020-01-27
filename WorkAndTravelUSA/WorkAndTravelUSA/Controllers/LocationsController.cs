using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorkAndTravelUSA.Models;

namespace WorkAndTravelUSA.Controllers
{
    [Authorize]
    public class LocationsController : Controller
    {
        private UsaContext db = new UsaContext();

        // GET: Locations
        [AllowAnonymous]
        public ActionResult Index()
        {
          
            return View(db.locationModels.ToList());
        }

        //Get: Locations/CreateComment
        public ActionResult CreateComment(int id)
        {
            var model = new Comment();

            var q = db.clientModels.Single(u => u.oduser == User.Identity.Name);
            model.idClient = q.Id;

            model.IdLoc = id;
            return RedirectToAction("Create", "Comments", model);
        }
        // GET: Locations/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.locationModels.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // GET: Locations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdClient,Name,State,Description,imgUrl")] Location location)
        {
            if (ModelState.IsValid)
            {
                location.IdClient = db.clientModels.Single(u => u.oduser == User.Identity.Name).Id;
                db.locationModels.Add(location);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(location);
        }

        // GET: Locations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.locationModels.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdClient,Name,State,Description,imgUrl")] Location location)
        {
            if (ModelState.IsValid)
            {
                db.Entry(location).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(location);
        }
        public JsonResult GetAllUser()
        {
            List<Client> clients = new List<Client>();

            string canVote = "No";
            clients = db.clientModels.ToList();
            foreach (Client c in clients)
            {
                if (c.oduser == User.Identity.Name && c.hasVote == "No")
                {
                    canVote = "Yes";
                    c.hasVote = "Yes";

                    db.SaveChanges();
                    break;
                }

            }

            return new JsonResult { Data = canVote, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public JsonResult SaveLocationRating(Location location)
        {
            
            if (db.locationModels.Find(location.Id).NumOfRatings != 0)
            {
                db.locationModels.Find(location.Id).Raiting = db.locationModels.Find(location.Id).Raiting + location.Raiting;
                db.locationModels.Find(location.Id).NumOfRatings = db.locationModels.Find(location.Id).NumOfRatings + 1;
                db.SaveChanges();

                db.locationModels.Find(location.Id).finalRating = db.locationModels.Find(location.Id).Raiting / db.locationModels.Find(location.Id).NumOfRatings;
                

            }
            else
            {
                db.locationModels.Find(location.Id).Raiting = location.Raiting;
                db.locationModels.Find(location.Id).finalRating = location.Raiting;
                db.locationModels.Find(location.Id).NumOfRatings = 1;
            }


            db.SaveChanges();

            return Json(location);
        }
        // GET: Locations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.locationModels.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Location location = db.locationModels.Find(id);
            db.locationModels.Remove(location);
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
