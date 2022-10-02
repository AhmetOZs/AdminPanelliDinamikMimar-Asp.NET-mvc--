using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimar.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anasayfas",
                columns: table => new
                {
                    AnaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BüyükResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BüyükResimSolYazi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BüyükResimBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hakkimdaparantezbaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaBaslik1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaAciklama1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaBaslik2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaAciklama2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde1Oran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde1Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde1Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde2Oran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde2Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde2Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde3Oran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde3Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde3Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde4Oran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yde4Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yuzde4Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurecParantezBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurecBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurecAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama1Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama1Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama2Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama2Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama3Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama3Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama4Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asama4Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anasayfas", x => x.AnaID);
                });

            migrationBuilder.CreateTable(
                name: "HizmetKategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetKategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Hizmetlers",
                columns: table => new
                {
                    HizmetlerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetlerAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetlerResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetlerParantezBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetlerBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetlerAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetlerAciklamaResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HizmetlerStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetlers", x => x.HizmetlerID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimParantezBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimYazi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Konum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IletisimID);
                });

            migrationBuilder.CreateTable(
                name: "Yorums",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumParantezBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumSirket = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorums", x => x.YorumID);
                });

            migrationBuilder.CreateTable(
                name: "Referanslars",
                columns: table => new
                {
                    ReferansID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferansAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferansGörsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referanslars", x => x.ReferansID);
                    table.ForeignKey(
                        name: "FK_Referanslars_HizmetKategoris_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "HizmetKategoris",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referanslars_KategoriID",
                table: "Referanslars",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anasayfas");

            migrationBuilder.DropTable(
                name: "Hizmetlers");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Referanslars");

            migrationBuilder.DropTable(
                name: "Yorums");

            migrationBuilder.DropTable(
                name: "HizmetKategoris");
        }
    }
}
