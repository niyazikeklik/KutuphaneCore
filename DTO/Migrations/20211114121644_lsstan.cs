using Microsoft.EntityFrameworkCore.Migrations;

namespace DTO.Migrations
{
    public partial class lsstan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ogrenciBorc",
                table: "Ogrencis",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Stok",
                table: "Kitaps",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ogrenciBorc",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "Stok",
                table: "Kitaps");
        }
    }
}
