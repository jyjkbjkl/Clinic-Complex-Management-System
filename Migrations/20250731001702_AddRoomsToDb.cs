using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_Complex_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Room_RoomId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hospitals_HospitalId",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameIndex(
                name: "IX_Room_HospitalId",
                table: "Rooms",
                newName: "IX_Rooms_HospitalId");

            migrationBuilder.AddColumn<int>(
                name: "HospitalId",
                table: "Hospitals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_HospitalId",
                table: "Hospitals",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Rooms_RoomId",
                table: "Appointments",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Hospitals_HospitalId",
                table: "Hospitals",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hospitals_HospitalId",
                table: "Rooms",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Rooms_RoomId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Hospitals_HospitalId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hospitals_HospitalId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_HospitalId",
                table: "Hospitals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Rooms");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HospitalId",
                table: "Room",
                newName: "IX_Room_HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Room_RoomId",
                table: "Appointments",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hospitals_HospitalId",
                table: "Room",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
