using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models.Entity;

namespace WebProject.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        TransportSystemEntities db = new TransportSystemEntities();
        public ActionResult HomePage()
        {
            return View();
        }
    }
}