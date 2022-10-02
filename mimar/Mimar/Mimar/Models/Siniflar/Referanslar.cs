using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mimar.Models.Siniflar
{
    public class Referanslar
    {
        [Key]
        public int ReferansID { get; set; }
        public string ReferansAd { get; set; }
        public string ReferansGörsel { get; set; }

        [ForeignKey("HizmetKategori")]
        public int KategoriID { get; set; }       
        public virtual HizmetKategori HizmetKategori { get; set; }

        

    }
}
