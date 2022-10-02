using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.Linq;

namespace Mimar.Controllers
{
    public class AsamaController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Anasayfas.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult AsamaGetir(int id)
        {
            var byr = c.Anasayfas.Find(id);
            return View("AsamaGetir", byr);
        }
        [Authorize]
        public ActionResult AsamaGüncelle(Anasayfa k)
        {
            var ktgr = c.Anasayfas.Find(k.AnaID);
            ktgr.Asama1Baslik = k.Asama1Baslik;
            ktgr.Asama1Aciklama = k.Asama1Aciklama;
            ktgr.Asama2Baslik = k.Asama2Baslik;
            ktgr.Asama2Aciklama = k.Asama2Aciklama;
            ktgr.Asama3Baslik = k.Asama3Baslik;
            ktgr.Asama3Aciklama = k.Asama3Aciklama;
            ktgr.Asama4Baslik = k.Asama4Baslik;
            ktgr.Asama4Aciklama = k.Asama4Aciklama;
           
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
