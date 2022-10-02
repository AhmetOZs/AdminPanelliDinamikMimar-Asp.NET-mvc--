using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using System.Linq;

namespace Mimar.Controllers
{
    public class IletisimController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Iletisims.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult IletisimGetir(int id)
        {
            var byr = c.Iletisims.Find(id);
            return View("IletisimGetir", byr);
        }
        [Authorize]
        public ActionResult IletisimGüncelle(Iletisim k)
        {
            var ktgr = c.Iletisims.Find(k.IletisimID);
            ktgr.Facebook = k.Facebook;
            ktgr.Instagram = k.Instagram;
            ktgr.Twitter = k.Twitter;
            ktgr.Linkedin = k.Linkedin;
            ktgr.IletisimParantezBaslik = k.IletisimParantezBaslik;
            ktgr.IletisimBaslik = k.IletisimBaslik;
            ktgr.IletisimYazi = k.IletisimYazi;
            ktgr.Adres = k.Adres;
            ktgr.Telefon = k.Telefon;
            ktgr.Mail = k.Mail;
            ktgr.Konum = k.Konum;
            ktgr.FooterAciklama = k.FooterAciklama;


            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
