using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mimar.Models.Siniflar
{
    public class HizmetKategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }
        public List<Referanslar> Referanslars { get; set; }

        
    }
}
