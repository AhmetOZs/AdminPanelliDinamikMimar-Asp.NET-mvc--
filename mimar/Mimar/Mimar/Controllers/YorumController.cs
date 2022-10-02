using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.Linq;

namespace Mimar.Controllers
{
    public class YorumController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Yorums.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public ActionResult YorumEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult YorumEkle(Yorum k)
        {
            c.Yorums.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var byr = c.Yorums.Find(id);
            return View("YorumGetir", byr);
        }
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var ktg = c.Yorums.Find(id);
            c.Yorums.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumGüncelle(Yorum k)
        {
            var ktgr = c.Yorums.Find(k.YorumID);
            ktgr.YorumParantezBaslik = k.YorumParantezBaslik;
            ktgr.YorumAciklama = k.YorumAciklama;
            ktgr.YorumAd = k.YorumAd;
            ktgr.YorumSirket = k.YorumSirket;
           
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
