using System.ComponentModel.DataAnnotations;

namespace Mimar.Models.Siniflar
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public char Yetki { get; set; }
    }
}
