using System.ComponentModel.DataAnnotations;

namespace Mimar.Models.Siniflar
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        public string YorumParantezBaslik { get; set; }
        public string YorumAciklama { get; set; }
        public string YorumAd { get; set; }
        public string YorumSirket { get; set; }
        
    }
}
