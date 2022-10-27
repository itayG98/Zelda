using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zelda.Migrations
{
    public partial class FixedTypoimgSrc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imgSrc",
                table: "Toppings",
                newName: "ImgSrc");

            migrationBuilder.RenameColumn(
                name: "imgSrc",
                table: "Syrops",
                newName: "ImgSrc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgSrc",
                table: "Toppings",
                newName: "imgSrc");

            migrationBuilder.RenameColumn(
                name: "ImgSrc",
                table: "Syrops",
                newName: "imgSrc");
        }
    }
}
