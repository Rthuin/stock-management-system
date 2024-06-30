using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminPassword",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Admins",
                newName: "AdminID");

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admins",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Admins",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Admins",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Admins",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_ProductCode",
                table: "Products",
                column: "ProductCode");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_AdminID",
                table: "Stocks",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductCode",
                table: "Stocks",
                column: "ProductCode");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockCode",
                table: "Stocks",
                column: "StockCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCode",
                table: "Products",
                column: "ProductCode",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Admins_AdminID",
                table: "Stocks",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductCode",
                table: "Stocks",
                column: "ProductCode",
                principalTable: "Products",
                principalColumn: "ProductCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Admins_AdminID",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Products_ProductCode",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_AdminID",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ProductCode",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_StockCode",
                table: "Stocks");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_ProductCode",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "AdminID",
                table: "Admins",
                newName: "AdminId");

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Stocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdminPassword",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
