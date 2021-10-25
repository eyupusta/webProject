using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models.Entity;

namespace WebProject.Controllers
{
    public class FerryLineController : Controller
    {
        // GET: FerryLine
        TransportSystemEntities db = new TransportSystemEntities();
        public ActionResult FerryLine()
        {
            return View();
        }
        public ActionResult ShowStationForFerryLine(string line)
        {
            var result = from d in db.FerryLines_Stations select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }
        public ActionResult ShowTimeForFerryLine(string line)
        {
            var result = from d in db.FerryLines_Times select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }

        public ActionResult ShowFerryLineForStation(string station)
        {
            var result = from d in db.FerryLines_Stations select d;
            result = result.Where(m => m.Stations.StationName == station);
            return View(result.ToList());
        }
    }
}