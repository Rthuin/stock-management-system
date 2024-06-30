using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Admins",
                newName: "AdminPassword");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Admins",
                newName: "AdminRole");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Admins",
                newName: "AdminName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Admins",
                newName: "AdminEmail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdminRole",
                table: "Admins",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "AdminPassword",
                table: "Admins",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "AdminName",
                table: "Admins",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "AdminEmail",
                table: "Admins",
                newName: "Email");
        }
    }
}
