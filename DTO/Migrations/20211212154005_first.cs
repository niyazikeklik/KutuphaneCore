using Microsoft.EntityFrameworkCore.Migrations;

namespace DTO.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TCno",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "Islem",
                table: "KutuphaneIslems");

            migrationBuilder.RenameColumn(
                name: "OgrenciNo",
                table: "Ogrencis",
                newName: "OgrenciTC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgrenciTC",
                table: "Ogrencis",
                newName: "OgrenciNo");

            migrationBuilder.AddColumn<string>(
                name: "TCno",
                table: "Ogrencis",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Islem",
                table: "KutuphaneIslems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
