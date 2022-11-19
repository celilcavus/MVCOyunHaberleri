using OyunHaberleri.Models.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OyunHaberleri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            return View(DbHomePage.getQuery("select * from OyunHaberleri"));
        }
    }
}