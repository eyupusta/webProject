using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models.Entity;

namespace WebProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        TransportSystemEntities db = new TransportSystemEntities();
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}