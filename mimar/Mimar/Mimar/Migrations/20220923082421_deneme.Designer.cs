// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mimar.Models.Siniflar;

namespace Mimar.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220923082421_deneme")]
    partial class deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mimar.Models.Siniflar.Anasayfa", b =>
                {
                    b.Property<int>("AnaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Asama1Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asama1Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asama2Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asama2Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asama3Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asama3Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asama4Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asama4Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BüyükResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BüyükResimBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BüyükResimSolYazi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimdaAciklama1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimdaAciklama2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimdaBaslik1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimdaBaslik2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hakkimdaparantezbaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurecAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurecBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurecParantezBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yde4Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde1Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde1Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde1Oran")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde2Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde2Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde2Oran")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde3Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde3Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde3Oran")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde4Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuzde4Oran")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnaID");

                    b.ToTable("Anasayfas");
                });

            modelBuilder.Entity("Mimar.Models.Siniflar.HizmetKategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("HizmetKategoris");
                });

            modelBuilder.Entity("Mimar.Models.Siniflar.Hizmetler", b =>
                {
                    b.Property<int>("HizmetlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HizmetlerAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetlerAciklamaResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetlerAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetlerBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetlerParantezBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetlerResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetlerStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HizmetlerID");

                    b.ToTable("Hizmetlers");
                });

            modelBuilder.Entity("Mimar.Models.Siniflar.Iletisim", b =>
                {
                    b.Property<int>("IletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimParantezBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimYazi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IletisimID");

                    b.ToTable("Iletisims");
                });

            modelBuilder.Entity("Mimar.Models.Siniflar.Referanslar", b =>
                {
                    b.Property<int>("ReferansID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("ReferansAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferansGörsel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferansID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Referanslars");
                });

            modelBuilder.Entity("Mimar.Models.Siniflar.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YorumAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumParantezBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumSirket")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumID");

                    b.ToTable("Yorums");
                });

            modelBuilder.Entity("Mimar.Models.Siniflar.Referanslar", b =>
                {
                    b.HasOne("Mimar.Models.Siniflar.HizmetKategori", "HizmetKategori")
                        .WithMany("Referanslars")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HizmetKategori");
                });

            modelBuilder.Entity("Mimar.Models.Siniflar.HizmetKategori", b =>
                {
                    b.Navigation("Referanslars");
                });
#pragma warning restore 612, 618
        }
    }
}
