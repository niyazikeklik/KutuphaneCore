using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DTO.Migrations
{
    public partial class s : Migration
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
                    KitapTuru = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.BarkodNo);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsimSoyisim = table.Column<string>(type: "TEXT", nullable: true),
                    TCno = table.Column<int>(type: "INTEGER", nullable: false),
                    TelefonNo = table.Column<string>(type: "TEXT", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciNo);
                });

            migrationBuilder.CreateTable(
                name: "KutuphaneIslems",
                columns: table => new
                {
                    IslemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgrenciNo = table.Column<int>(type: "INTEGER", nullable: false),
                    KitapBarkodNo = table.Column<int>(type: "INTEGER", nullable: false),
                    AlimTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IadeTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Islem = table.Column<int>(type: "INTEGER", nullable: false)
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
                        name: "FK_KutuphaneIslems_Ogrencis_OgrenciNo",
                        column: x => x.OgrenciNo,
                        principalTable: "Ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KutuphaneIslems_KitapBarkodNo",
                table: "KutuphaneIslems",
                column: "KitapBarkodNo");

            migrationBuilder.CreateIndex(
                name: "IX_KutuphaneIslems_OgrenciNo",
                table: "KutuphaneIslems",
                column: "OgrenciNo");
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
