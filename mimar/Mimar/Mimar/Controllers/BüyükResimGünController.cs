using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mimar.Controllers
{
    public class BüyükResimGünController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Anasayfas.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult BüyükResimGünGetir(int id)
        {
            var byr = c.Anasayfas.Find(id);
            return View("BüyükResimGünGetir", byr);
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> BüyükResimGünGüncelle(Anasayfa k, IFormFile fileImg)
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
                k.BüyükResim = "/uploads/" + fileImg.FileName;
                ktgr.BüyükResim = k.BüyükResim;
            }
           
            
            ktgr.BüyükResimSolYazi = k.BüyükResimSolYazi;
            ktgr.BüyükResimBaslik = k.BüyükResimBaslik;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
