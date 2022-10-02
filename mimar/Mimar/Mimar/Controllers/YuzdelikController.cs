using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.Linq;

namespace Mimar.Controllers
{
    public class YuzdelikController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Anasayfas.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult YuzdelikGetir(int id)
        {
            var byr = c.Anasayfas.Find(id);
            return View("YuzdelikGetir", byr);
        }
        [Authorize]
        public ActionResult YuzdelikGüncelle(Anasayfa k)
        {
            var ktgr = c.Anasayfas.Find(k.AnaID);
            ktgr.Yuzde1Oran = k.Yuzde1Oran;
            ktgr.Yuzde1Baslik = k.Yuzde1Baslik;
            ktgr.Yuzde1Aciklama = k.Yuzde1Aciklama;
            ktgr.Yuzde2Oran = k.Yuzde2Oran;
            ktgr.Yuzde2Baslik = k.Yuzde2Baslik;
            ktgr.Yuzde2Aciklama = k.Yuzde2Aciklama;
            ktgr.Yuzde3Oran = k.Yuzde3Oran;
            ktgr.Yuzde3Baslik = k.Yuzde3Baslik;
            ktgr.Yuzde3Aciklama = k.Yuzde3Aciklama;
            ktgr.Yuzde4Oran = k.Yuzde4Oran;
            ktgr.Yde4Baslik = k.Yde4Baslik;
            ktgr.Yuzde4Aciklama = k.Yuzde4Aciklama;
   
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
