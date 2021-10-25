using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models.Entity;

namespace WebProject.Controllers
{
    public class RailSystemController : Controller
    {
        // GET: RailSystem
        TransportSystemEntities db = new TransportSystemEntities();
        public ActionResult RailSystem()
        {
            return View();
        }
        public ActionResult ShowStationFormRailSystem(string line)
        {
            var result = from d in db.RailSystems_Stations select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }
        public ActionResult ShowTimeFormRailSystem(string line)
        {
            var result = from d in db.RailSystems_Times select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }

        public ActionResult ShowLineFormStation(string station)
        {
            var result = from d in db.RailSystems_Stations select d;
            result = result.Where(m => m.Stations.StationName == station);
            return View(result.ToList());
        }

    }
}