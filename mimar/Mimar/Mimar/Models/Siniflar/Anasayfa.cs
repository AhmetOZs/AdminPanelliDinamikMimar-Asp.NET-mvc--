using System.ComponentModel.DataAnnotations;

namespace Mimar.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int AnaID { get; set; }
       
        public string BüyükResim { get; set; }
        public string BüyükResimSolYazi { get; set; }
        public string BüyükResimBaslik { get; set; }
        public string Hakkimdaparantezbaslik { get; set; }
        public string HakkimdaResim { get; set; }
        public string HakkimdaBaslik1 { get; set; }
        public string HakkimdaAciklama1 { get; set; }
        public string HakkimdaBaslik2 { get; set; }
        public string HakkimdaAciklama2 { get; set; }
        public string Yuzde1Oran { get; set; }
        public string Yuzde1Baslik { get; set; }
        public string Yuzde1Aciklama { get; set; }
        public string Yuzde2Oran { get; set; }
        public string Yuzde2Baslik { get; set; }
        public string Yuzde2Aciklama { get; set; }
        public string Yuzde3Oran { get; set; }
        public string Yuzde3Baslik { get; set; }
        public string Yuzde3Aciklama { get; set; }
        public string Yuzde4Oran { get; set; }
        public string Yde4Baslik { get; set; }
        public string Yuzde4Aciklama { get; set; }        
        public string SurecParantezBaslik { get; set; }
        public string SurecBaslik { get; set; }
        public string SurecAciklama { get; set; }
        public string Asama1Baslik { get; set; }
        public string Asama1Aciklama { get; set; }
        public string Asama2Baslik { get; set; }
        public string Asama2Aciklama { get; set; }
        public string Asama3Baslik { get; set; }
        public string Asama3Aciklama { get; set; }
        public string Asama4Baslik { get; set; }
        public string Asama4Aciklama { get; set; }


    }
}
