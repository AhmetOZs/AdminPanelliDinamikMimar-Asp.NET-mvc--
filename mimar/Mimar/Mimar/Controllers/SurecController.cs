using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.Linq;

namespace Mimar.Controllers
{
    public class SurecController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Anasayfas.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult SurecGetir(int id)
        {
            var byr = c.Anasayfas.Find(id);
            return View("SurecGetir", byr);
        }
        [Authorize]
        public ActionResult SurecGüncelle(Anasayfa k)
        {
            var ktgr = c.Anasayfas.Find(k.AnaID);
            ktgr.SurecParantezBaslik = k.SurecParantezBaslik;
            ktgr.SurecBaslik = k.SurecBaslik;
            ktgr.SurecAciklama = k.SurecAciklama;
           

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
