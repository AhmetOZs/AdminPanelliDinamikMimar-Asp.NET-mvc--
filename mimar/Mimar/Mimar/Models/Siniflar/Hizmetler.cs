using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mimar.Models.Siniflar
{
    public class Hizmetler
    {
        [Key]
        public int HizmetlerID { get; set; }
        public string HizmetlerAd { get; set; }
        public string HizmetlerResim { get; set; }
        
        public string HizmetlerParantezBaslik { get; set; }
        public string HizmetlerBaslik { get; set; }
        public string HizmetlerAciklama { get; set; }
        public string HizmetlerAciklamaResim { get; set; }
        public string HizmetlerStatus { get; set; }

        
    }
}
