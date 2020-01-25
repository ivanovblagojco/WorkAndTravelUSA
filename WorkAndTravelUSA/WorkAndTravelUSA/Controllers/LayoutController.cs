using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkAndTravelUSA.Models;

namespace WorkAndTravelUSA.Controllers
{
    public class LayoutController : Controller
    {
        private UsaContext db = new UsaContext();
        // GET: Layout
        public ActionResult Index()
        {
            ViewBag.Locations = db.locationModels.ToList();
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}