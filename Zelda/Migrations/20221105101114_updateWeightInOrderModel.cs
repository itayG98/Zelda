using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zelda.Migrations
{
    public partial class updateWeightInOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IceCreamWeight",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IceCreamWeight",
                table: "Orders");
        }
    }
}
