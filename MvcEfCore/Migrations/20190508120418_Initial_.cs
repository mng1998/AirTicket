using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcEfCore.Migrations
{
    public partial class Initial_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoGheHang2",
                table: "LichChuyenBays",
                newName: "EconomyClass");

            migrationBuilder.RenameColumn(
                name: "SoGheHang1",
                table: "LichChuyenBays",
                newName: "BusinessClass");

            migrationBuilder.AddColumn<string>(
                name: "DenId",
                table: "LichChuyenBays",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KhoiHanhId",
                table: "LichChuyenBays",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DenId",
                table: "LichChuyenBays");

            migrationBuilder.DropColumn(
                name: "KhoiHanhId",
                table: "LichChuyenBays");

            migrationBuilder.RenameColumn(
                name: "EconomyClass",
                table: "LichChuyenBays",
                newName: "SoGheHang2");

            migrationBuilder.RenameColumn(
                name: "BusinessClass",
                table: "LichChuyenBays",
                newName: "SoGheHang1");
        }
    }
}
