using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace McSystems.DataAccess.Migrations
{
    public partial class ContextUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerReservation_Reservations_ReservationsId",
                table: "CustomerReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Room_RoomId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservation",
                newName: "IX_Reservation_RoomId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Reservation",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Reservation",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_EmployeeId",
                table: "Reservation",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerReservation_Reservation_ReservationsId",
                table: "CustomerReservation",
                column: "ReservationsId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Employee_EmployeeId",
                table: "Reservation",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Room_RoomId",
                table: "Reservation",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerReservation_Reservation_ReservationsId",
                table: "CustomerReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Employee_EmployeeId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Room_RoomId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_EmployeeId",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_RoomId",
                table: "Reservations",
                newName: "IX_Reservations_RoomId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerReservation_Reservations_ReservationsId",
                table: "CustomerReservation",
                column: "ReservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Room_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
