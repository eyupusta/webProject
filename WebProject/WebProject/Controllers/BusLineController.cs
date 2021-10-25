using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models.Entity;

namespace WebProject.Controllers
{
    public class BusLineController : Controller
    {
        // GET: BusLine
        TransportSystemEntities db = new TransportSystemEntities();
        public ActionResult BusLine()
        {
            return View();
        }

        public ActionResult ShowStationForBusLine(string line)
        {
            var result = from d in db.BusLines_Stations select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }
        public ActionResult ShowTimeForBusLine(string line)
        {
            var result = from d in db.BusLines_Times select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }

        public ActionResult ShowBusLineForStation(string station)
        {
            var result = from d in db.BusLines_Stations select d;
            result = result.Where(m => m.Stations.StationName == station);
            return View(result.ToList());
        }
    }
}