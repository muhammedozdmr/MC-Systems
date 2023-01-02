using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace McSystems.DataAccess.Migrations
{
    public partial class RoomSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Capacity", "Description", "Floor", "InMaintenance", "Number", "RoomType" },
                values: new object[,]
                {
                    { 1, (byte)2, "2 kişilik çift yataklı oda", (byte)1, false, (byte)1, 2 },
                    { 2, (byte)2, "2 kişilik çift yataklı oda", (byte)1, false, (byte)2, 2 },
                    { 3, (byte)2, "2 kişilik tek yataklı oda", (byte)1, false, (byte)3, 1 },
                    { 4, (byte)4, "2 kişilik 2 adet çift yataklı oda", (byte)2, false, (byte)1, 10 },
                    { 5, (byte)5, "deniz manzaralı 5 kişilik çift yataklı oda", (byte)2, false, (byte)2, 6 },
                    { 6, (byte)6, "çift yataklı aile odası", (byte)2, false, (byte)3, 9 },
                    { 7, (byte)6, "çift yataklı oda suite", (byte)3, false, (byte)1, 12 },
                    { 8, (byte)4, "4 kişilik çift yataklı oda", (byte)3, false, (byte)2, 4 },
                    { 9, (byte)4, "4 kişilik çift yataklı oda", (byte)3, false, (byte)3, 3 },
                    { 10, (byte)10, "10 kişilik çift yataklı oda", (byte)4, false, (byte)1, 12 },
                    { 11, (byte)4, "4 kişilik çift yataklı oda", (byte)4, false, (byte)2, 7 },
                    { 12, (byte)8, "8 kişilik çift yataklı oda", (byte)4, false, (byte)3, 9 },
                    { 13, (byte)2, "2 kişilik çift yataklı oda", (byte)5, false, (byte)1, 12 },
                    { 14, (byte)3, "3 kişilik çift yataklı juniorsuite oda", (byte)5, false, (byte)2, 6 },
                    { 15, (byte)6, "6 kişilik çift yataklı kingsuite oda", (byte)5, false, (byte)3, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
