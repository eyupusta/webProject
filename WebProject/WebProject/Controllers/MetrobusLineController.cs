using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models.Entity;

namespace WebProject.Controllers
{
    public class MetrobusLineController : Controller
    {
        // GET: MetrobusLine
        TransportSystemEntities db = new TransportSystemEntities();
        public ActionResult MetrobusLine()
        {
            return View();
        }
        public ActionResult ShowStationForMetrobusLine(string line)
        {
            var result = from d in db.MetrobusLines_Stations select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }
        public ActionResult ShowTimeForMetrobusLine(string line)
        {
            var result = from d in db.MetrobusLines_Times select d;
            result = result.Where(m => m.LineID == line);
            return View(result.ToList());
        }

        public ActionResult ShowMetrobusLineForStation(string station)
        {
            var result = from d in db.MetrobusLines_Stations select d;
            result = result.Where(m => m.Stations.StationName == station);
            return View(result.ToList());
        }
    }
}