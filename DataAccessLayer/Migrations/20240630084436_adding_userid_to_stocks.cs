using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class adding_userid_to_stocks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_UserID",
                table: "Stocks",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Users_UserID",
                table: "Stocks",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Users_UserID",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_UserID",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Stocks");
        }
    }
}
