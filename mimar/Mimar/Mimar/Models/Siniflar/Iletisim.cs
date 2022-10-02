using System.ComponentModel.DataAnnotations;

namespace Mimar.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string IletisimParantezBaslik { get; set; }
        public string IletisimBaslik { get; set; }
        public string IletisimYazi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Konum { get; set; }
        public string FooterAciklama { get; set; }

    }
}
