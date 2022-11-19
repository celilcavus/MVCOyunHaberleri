using OyunHaberleri.Models.dbAbaout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OyunHaberleri.Controllers
{
    public class AbaoutController : Controller
    {
        // GET: Abaout
        public ActionResult AbaoutPage()
        {
            return View(DbAbaout.getAbaoutList());
        }
    }
}