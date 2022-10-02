using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mimar.Controllers
{
    public class HakkımdaController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Anasayfas.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult HakkımdaGetir(int id)
        {
            var byr = c.Anasayfas.Find(id);
            return View("HakkımdaGetir",  byr);
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> HakkımdaGüncelle(Anasayfa k, IFormFile fileImg)
        {
            var ktgr = c.Anasayfas.Find(k.AnaID);
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
                k.HakkimdaResim = "/uploads/" + fileImg.FileName;
                ktgr.HakkimdaResim = k.HakkimdaResim;
            }
            
            ktgr.Hakkimdaparantezbaslik = k.Hakkimdaparantezbaslik;
            ktgr.HakkimdaBaslik1 = k.HakkimdaBaslik1;
            ktgr.HakkimdaAciklama1 = k.HakkimdaAciklama1;
            ktgr.HakkimdaBaslik2 = k.HakkimdaBaslik2;
            ktgr.HakkimdaAciklama2 = k.HakkimdaAciklama2;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
