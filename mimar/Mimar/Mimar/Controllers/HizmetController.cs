using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mimar.Controllers
{
    public class HizmetController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Hizmetlers.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public ActionResult HizmetEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult>  HizmetEkle(Hizmetler k, IFormFile fileImg, IFormFile fileImg2)
        {
            
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
                k.HizmetlerResim = "/uploads/" + fileImg.FileName;
            }
             if (fileImg2 != null)
            {

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", fileImg2.FileName);

                using (Stream fileStream2 = new FileStream(konumdegeri2, FileMode.Create))
                {
                    await fileImg2.CopyToAsync(fileStream2);
                }
                k.HizmetlerAciklamaResim = "/uploads/" + fileImg2.FileName;
               
            }
            c.Hizmetlers.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult HizmetSil(int id)
        {
            var ktg = c.Hizmetlers.Find(id);
            c.Hizmetlers.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult HizmetGetir(int id)
        {
            var hizmetler = c.Hizmetlers.Find(id);
            return View("HizmetGetir", hizmetler);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> HizmetGüncelle(Hizmetler k, IFormFile fileImg, IFormFile fileImg2)
        {
            var ktgr = c.Hizmetlers.Find(k.HizmetlerID);
            if (fileImg != null)
            {
              
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads",fileImg.FileName);
             
                using (Stream fileStream = new FileStream(konumdegeri, FileMode.Create))
                {
                    await fileImg.CopyToAsync(fileStream);
                }
                k.HizmetlerResim = "/uploads/" + fileImg.FileName; 
                ktgr.HizmetlerResim = k.HizmetlerResim;
            }
             if (fileImg2 != null)
            {
              
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads",fileImg2.FileName);
             
                using (Stream fileStream2 = new FileStream(konumdegeri2, FileMode.Create))
                {
                    await fileImg2.CopyToAsync(fileStream2);
                }
                k.HizmetlerAciklamaResim = "/uploads/" + fileImg2.FileName;
                ktgr.HizmetlerAciklamaResim = k.HizmetlerAciklamaResim;
            }

            
            ktgr.HizmetlerAd = k.HizmetlerAd;
            
            ktgr.HizmetlerParantezBaslik = k.HizmetlerParantezBaslik;
            ktgr.HizmetlerBaslik = k.HizmetlerBaslik;
            ktgr.HizmetlerAciklama = k.HizmetlerAciklama;
            
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
