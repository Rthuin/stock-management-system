using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class stock_code_requirement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Stocks_StockCode",
                table: "Stocks");

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockCode",
                table: "Stocks",
                column: "StockCode",
                unique: true,
                filter: "[StockCode] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Stocks_StockCode",
                table: "Stocks");

            migrationBuilder.AlterColumn<string>(
                name: "StockCode",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockCode",
                table: "Stocks",
                column: "StockCode",
                unique: true);
        }
    }
}
