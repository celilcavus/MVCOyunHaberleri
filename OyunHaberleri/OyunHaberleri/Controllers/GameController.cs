using OyunHaberleri.Models.dbGamaPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OyunHaberleri.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult GamePage()
        {
            return View(DbGamePage.getGamePageList());
        }
    }
}