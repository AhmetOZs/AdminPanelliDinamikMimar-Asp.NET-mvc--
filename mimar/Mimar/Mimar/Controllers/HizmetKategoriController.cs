using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.Linq;

namespace Mimar.Controllers
{
    public class HizmetKategoriController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.HizmetKategoris.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult KategoriEkle(HizmetKategori k)
        {
            c.HizmetKategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult KategoriSil(int id)
        {
            var ktg = c.HizmetKategoris.Find(id);
            c.HizmetKategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.HizmetKategoris.Find(id);
            return View("KategoriGetir", kategori);
        }
        [Authorize]
        public ActionResult KategoriGüncelle(HizmetKategori k)
        {
            var ktgr = c.HizmetKategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
