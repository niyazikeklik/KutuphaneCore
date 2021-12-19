using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DTO.Migrations
{
    public partial class Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaps",
                columns: table => new
                {
                    BarkodNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapAd = table.Column<string>(type: "TEXT", nullable: true),
                    KitapYazar = table.Column<string>(type: "TEXT", nullable: true),
                    SayfaSayısı = table.Column<int>(type: "INTEGER", nullable: false),
                    BasimTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KitapTuru = table.Column<int>(type: "INTEGER", nullable: false),
                    Stok = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.BarkodNo);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsimSoyisim = table.Column<string>(type: "TEXT", nullable: true),
                    OgrenciTC = table.Column<string>(type: "TEXT", nullable: true),
                    TelefonNo = table.Column<string>(type: "TEXT", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "KutuphaneIslems",
                columns: table => new
                {
                    IslemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgrenciID = table.Column<int>(type: "INTEGER", nullable: false),
                    KitapBarkodNo = table.Column<int>(type: "INTEGER", nullable: false),
                    IslemUcret = table.Column<double>(type: "REAL", nullable: false),
                    AlimTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SonTeslimTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IadeTarihi = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KutuphaneIslems", x => x.IslemId);
                    table.ForeignKey(
                        name: "FK_KutuphaneIslems_Kitaps_KitapBarkodNo",
                        column: x => x.KitapBarkodNo,
                        principalTable: "Kitaps",
                        principalColumn: "BarkodNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KutuphaneIslems_Ogrencis_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrencis",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KutuphaneIslems_KitapBarkodNo",
                table: "KutuphaneIslems",
                column: "KitapBarkodNo");

            migrationBuilder.CreateIndex(
                name: "IX_KutuphaneIslems_OgrenciID",
                table: "KutuphaneIslems",
                column: "OgrenciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KutuphaneIslems");

            migrationBuilder.DropTable(
                name: "Kitaps");

            migrationBuilder.DropTable(
                name: "Ogrencis");
        }
    }
}
