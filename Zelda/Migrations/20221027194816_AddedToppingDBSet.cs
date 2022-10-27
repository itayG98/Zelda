using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zelda.Migrations
{
    public partial class AddedToppingDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Topping_ToppingID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topping",
                table: "Topping");

            migrationBuilder.RenameTable(
                name: "Topping",
                newName: "Toppings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "ToppingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Toppings_ToppingID",
                table: "Orders",
                column: "ToppingID",
                principalTable: "Toppings",
                principalColumn: "ToppingID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Toppings_ToppingID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "Topping");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topping",
                table: "Topping",
                column: "ToppingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Topping_ToppingID",
                table: "Orders",
                column: "ToppingID",
                principalTable: "Topping",
                principalColumn: "ToppingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
