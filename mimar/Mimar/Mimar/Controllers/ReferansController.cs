using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mimar.Models.Siniflar;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mimar.Controllers
{
    public class ReferansController : Controller
    {
        // GET: Urun
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            List<Referanslar> referanslars = c.Referanslars.ToList();
           
            List<HizmetKategori> hizmetKategori = c.HizmetKategoris.ToList();

            //List<Hizmetler> hizmetler = new();
            //hizmetler = c.Hizmetlers.ToList();

            //ViewBag.HizmetAd = hizmetler;




            return View(referanslars);

        }
        [HttpGet]

        [Authorize]
        public ActionResult ReferansEkle()
        {
            List<SelectListItem> deger1 = (from x in c.HizmetKategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> ReferansEkle(Referanslar k, IFormFile fileImg)
        {

            if (fileImg != null)
            {

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", fileImg.FileName);

                using (Stream fileStream = new FileStream(konumdegeri3, FileMode.Create))
                {
                    await fileImg.CopyToAsync(fileStream);
                }
                k.ReferansGörsel = "/uploads/" + fileImg.FileName;
            }


            c.Referanslars.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult ReferansSil(int id)
        {
            var ktg = c.Referanslars.Find(id);
            c.Referanslars.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult ReferansGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.HizmetKategoris.ToList() select new SelectListItem { Text = x.KategoriAd, Value = x.KategoriID.ToString() }).ToList();
            ViewBag.dgr1 = deger1;
            var referasdeger = c.Referanslars.Find(id);
            return View("ReferansGetir", referasdeger);
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> ReferansGüncelle(Referanslar k, IFormFile fileImg)
        {
            var ktgr = c.Referanslars.Find(k.ReferansID);
            if (fileImg != null)
            {

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", fileImg.FileName);

                using (Stream fileStream = new FileStream(konumdegeri, FileMode.Create))
                {
                    await fileImg.CopyToAsync(fileStream);
                }
                k.ReferansGörsel = "/uploads/" + fileImg.FileName;
                ktgr.ReferansGörsel = k.ReferansGörsel;
            }


            ktgr.ReferansAd = k.ReferansAd;
            ktgr.KategoriID = k.KategoriID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


