using OyunHaberleri.Models.Data;
using OyunHaberleri.Models.dbContact;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace OyunHaberleri.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult ContactPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactPage(iletisim iletisim)
        {
            if (ModelState.IsValid)
            {
                DbContact.InsertContact(iletisim);
            }
            return View();
        }
    }
}