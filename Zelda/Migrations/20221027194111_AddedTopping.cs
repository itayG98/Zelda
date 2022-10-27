using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zelda.Migrations
{
    public partial class AddedTopping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Syrops_ToopingSyropSyropID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ToopingSyropSyropID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ToopingSyropSyropID",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ToopingSyropID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToppingID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Topping",
                columns: table => new
                {
                    ToppingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    imgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping", x => x.ToppingID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToopingSyropID",
                table: "Orders",
                column: "ToopingSyropID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToppingID",
                table: "Orders",
                column: "ToppingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Syrops_ToopingSyropID",
                table: "Orders",
                column: "ToopingSyropID",
                principalTable: "Syrops",
                principalColumn: "SyropID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Topping_ToppingID",
                table: "Orders",
                column: "ToppingID",
                principalTable: "Topping",
                principalColumn: "ToppingID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Syrops_ToopingSyropID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Topping_ToppingID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ToopingSyropID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ToppingID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ToopingSyropID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ToppingID",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ToopingSyropSyropID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToopingSyropSyropID",
                table: "Orders",
                column: "ToopingSyropSyropID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Syrops_ToopingSyropSyropID",
                table: "Orders",
                column: "ToopingSyropSyropID",
                principalTable: "Syrops",
                principalColumn: "SyropID");
        }
    }
}
