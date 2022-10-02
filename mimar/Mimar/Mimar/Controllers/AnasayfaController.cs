using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Mimar.Models.Siniflar;
using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace Mimar.Controllers
{
    public class AnasayfaController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            List<Referanslar> referanslars = c.Referanslars.ToList();

            List<HizmetKategori> hizmetKategori = c.HizmetKategoris.ToList();

            List<Iletisim> iletisims = new();
            iletisims = c.Iletisims.ToList();
            ViewBag.iletisim = iletisims;

            List<HizmetKategori> hizmetKategoris = new();
            hizmetKategoris = c.HizmetKategoris.ToList();
            ViewBag.kategori = hizmetKategoris;


            List<Yorum> yorums = new();
            yorums = c.Yorums.ToList();
            ViewBag.yorum = yorums;

            List<Referanslar> referanslar = new();
            referanslars = c.Referanslars.ToList();
            ViewBag.referans = referanslars;

            var degerler = c.Anasayfas.ToList();
            return View(degerler);

            
        }
        public ActionResult Services(int id)
        {
            List<Iletisim> iletisims = new();
            iletisims = c.Iletisims.ToList();
            ViewBag.iletisim = iletisims;
            List<Hizmetler> hizmetlers = new();
            hizmetlers = c.Hizmetlers.ToList();
            
            var hizmetler = c.Hizmetlers.Find(id == 0 ? hizmetlers[0].HizmetlerID : id);
            ViewBag.Hizmet = hizmetler;
            ViewBag.Hizmetler = hizmetlers;
            return View();
        }
        public ActionResult Iletisim()
        {
            ////var message = new MimeMessage();
            ////message.From.Add(new MailboxAddress("test" , "projetest@gmail.com"));
            ////message.To.Add(new MailboxAddress("narem", "ahmet_drap@windowslive.com"));
            ////message.Subject = "deneme subject";
            ////message.Body = new TextPart("plain")
            //{
            //    Text = "denemebody"
            //};
            //using (var client= new SmtpClient())
            //{
            //    //client.Connect("smtp.gmail.com", 587,false);
            //    //client.Authenticate("projetest@gmail.com", "visualstudio");
            //    //client.Send(message);
            //    //client.Disconnect(true);
                
                

            //}
            
            var degerler = c.Iletisims.ToList();
            return View(degerler);
            
        }
        public ActionResult ReferansFull(int id)
        {
            List<Referanslar> referanslars = c.Referanslars.ToList();

            List<HizmetKategori> hizmetKategori = c.HizmetKategoris.ToList();

            List<Iletisim> iletisims = new();
            iletisims = c.Iletisims.ToList();
            ViewBag.iletisim = iletisims;

            List<HizmetKategori> hizmetKategoris = new();
            hizmetKategoris = c.HizmetKategoris.ToList();
            ViewBag.kategori = hizmetKategoris;

            var degerler = c.Referanslars.ToList();
            return View(degerler);

            
        }
        
    }
}
