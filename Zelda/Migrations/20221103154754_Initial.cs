using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zelda.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "IceCreams",
                columns: table => new
                {
                    IceCreamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IceCreams", x => x.IceCreamID);
                });

            migrationBuilder.CreateTable(
                name: "Syrops",
                columns: table => new
                {
                    SyropID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syrops", x => x.SyropID);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    ToppingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.ToppingID);
                });

            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CostumerAdrressID = table.Column<int>(type: "int", nullable: false),
                    AdrressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Costumers_Addresses_AdrressID",
                        column: x => x.AdrressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CostumerID = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    OrderedIceCreamID = table.Column<int>(type: "int", nullable: false),
                    ToopingSyropID = table.Column<int>(type: "int", nullable: false),
                    ToppingID = table.Column<int>(type: "int", nullable: false),
                    AdditionalPhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AlternativeAdrressID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AlternativeAdrressID",
                        column: x => x.AlternativeAdrressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID");
                    table.ForeignKey(
                        name: "FK_Orders_Costumers_CostumerID",
                        column: x => x.CostumerID,
                        principalTable: "Costumers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_IceCreams_OrderedIceCreamID",
                        column: x => x.OrderedIceCreamID,
                        principalTable: "IceCreams",
                        principalColumn: "IceCreamID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Syrops_ToopingSyropID",
                        column: x => x.ToopingSyropID,
                        principalTable: "Syrops",
                        principalColumn: "SyropID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Toppings_ToppingID",
                        column: x => x.ToppingID,
                        principalTable: "Toppings",
                        principalColumn: "ToppingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IceCreams",
                columns: new[] { "IceCreamID", "ImgSrc", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Default", "Chocolate Milk", 6.5 },
                    { 2, "Default", "Yummy Vannila", 6.0 },
                    { 3, "Default", "Strawberry", 5.0 },
                    { 4, "Default", "Juicy Lemon", 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Syrops",
                columns: new[] { "SyropID", "ImgSrc", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Default", "Strawberry", 3.0 },
                    { 2, "Default", "Dark Chocolate", 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ToppingID", "ImgSrc", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Default", "Pecans", 3.0 },
                    { 2, "Default", "Candies", 3.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costumers_AdrressID",
                table: "Costumers",
                column: "AdrressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AlternativeAdrressID",
                table: "Orders",
                column: "AlternativeAdrressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CostumerID",
                table: "Orders",
                column: "CostumerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderedIceCreamID",
                table: "Orders",
                column: "OrderedIceCreamID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToopingSyropID",
                table: "Orders",
                column: "ToopingSyropID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToppingID",
                table: "Orders",
                column: "ToppingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "IceCreams");

            migrationBuilder.DropTable(
                name: "Syrops");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
