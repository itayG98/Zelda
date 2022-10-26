using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zelda.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addreses",
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
                    table.PrimaryKey("PK_Addreses", x => x.AddressID);
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
                    imgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syrops", x => x.SyropID);
                });

            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AdrressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Costumers_Addreses_AdrressID",
                        column: x => x.AdrressID,
                        principalTable: "Addreses",
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
                    ToopingSyropSyropID = table.Column<int>(type: "int", nullable: true),
                    AdditionalPhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AlternativeAddrresID = table.Column<int>(type: "int", nullable: true)
                },
               constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
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
                        name: "FK_Orders_Syrops_ToopingSyropSyropID",
                        column: x => x.ToopingSyropSyropID,
                        principalTable: "Syrops",
                        principalColumn: "SyropID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costumers_AdrressID",
                table: "Costumers",
                column: "AdrressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CostumerID",
                table: "Orders",
                column: "CostumerID");

            migrationBuilder.CreateIndex(
               name: "IX_Orders_OrderedIceCreamID",
               table: "Orders",
                column: "OrderedIceCreamID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToopingSyropSyropID",
                table: "Orders",
                column: "ToopingSyropSyropID");
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
                name: "Addreses");
        }
    }
}
