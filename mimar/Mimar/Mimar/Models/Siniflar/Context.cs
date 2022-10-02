using Microsoft.EntityFrameworkCore;

namespace Mimar.Models.Siniflar
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MEBCOLL\\SQLEXPRESS; database=MimarData; integrated security=true");
        }
        public DbSet <Anasayfa> Anasayfas{ get; set; }       
        public DbSet <HizmetKategori> HizmetKategoris{ get; set; }
        public DbSet <Hizmetler> Hizmetlers{ get; set; }
        public DbSet <Iletisim> Iletisims{ get; set; }
        public DbSet <Referanslar> Referanslars{ get; set; }
        public DbSet <Yorum> Yorums{ get; set; }
        public DbSet<Login> Logins{ get; set; }
    }
}
