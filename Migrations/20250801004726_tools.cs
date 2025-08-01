using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_Complex_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class tools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Hospitals_HospitalId",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_HospitalId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Hospitals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HospitalId",
                table: "Hospitals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_HospitalId",
                table: "Hospitals",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Hospitals_HospitalId",
                table: "Hospitals",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id");
        }
    }
}
