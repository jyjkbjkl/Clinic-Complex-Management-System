using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_Complex_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class AddNameAndRoleToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "Role");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "FullName");
        }
    }
}
