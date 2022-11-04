using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zelda.Migrations
{
    public partial class RegexRefactoting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdditionalPhoneNumber",
                table: "Orders",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Costumers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 1,
                column: "ImgSrc",
                value: "Chocolate_Milk_img.png");

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 2,
                column: "ImgSrc",
                value: "Yummy_vanilla.png");

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 3,
                column: "ImgSrc",
                value: "StrawBerry_imge.png");

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 4,
                column: "ImgSrc",
                value: "JuicyLemno_Image.png");

            migrationBuilder.UpdateData(
                table: "Syrops",
                keyColumn: "SyropID",
                keyValue: 1,
                column: "ImgSrc",
                value: "Strawberry_Syrop.png");

            migrationBuilder.UpdateData(
                table: "Syrops",
                keyColumn: "SyropID",
                keyValue: 2,
                column: "ImgSrc",
                value: "Chocolate_Syrop.png");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "ToppingID",
                keyValue: 1,
                column: "ImgSrc",
                value: "Pecans_Top.png");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "ToppingID",
                keyValue: 2,
                column: "ImgSrc",
                value: "Candis_Top.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdditionalPhoneNumber",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Costumers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 1,
                column: "ImgSrc",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 2,
                column: "ImgSrc",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 3,
                column: "ImgSrc",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "IceCreams",
                keyColumn: "IceCreamID",
                keyValue: 4,
                column: "ImgSrc",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "Syrops",
                keyColumn: "SyropID",
                keyValue: 1,
                column: "ImgSrc",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "Syrops",
                keyColumn: "SyropID",
                keyValue: 2,
                column: "ImgSrc",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "ToppingID",
                keyValue: 1,
                column: "ImgSrc",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "ToppingID",
                keyValue: 2,
                column: "ImgSrc",
                value: "Default");
        }
    }
}
