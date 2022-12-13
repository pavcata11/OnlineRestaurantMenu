using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRestaurantMenu.Infrastructure.Migrations
{
    public partial class addWaiterConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "566d2622-fe79-4a63-b99f-97055f4a70e2", "7d6711eb-df84-4c7c-ba3f-a04de0f4f8c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "965ac61b-7b7c-4c5b-8a8b-55b515335dd5", "ffaf3542-d4b7-471f-84ab-a0ec840d28e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95906b5d-0fab-45f1-ab55-6808a8c9d716", "ca117268-6570-4341-a7fa-36936d72844e" });

            migrationBuilder.InsertData(
                table: "Waiters",
                columns: new[] { "Id", "DateStartWork", "UserId" },
                values: new object[] { 1, new DateTime(2022, 12, 13, 22, 50, 39, 671, DateTimeKind.Local).AddTicks(3467), "4b7f2886-0c38-41b3-8281-b6fc1f465838" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d3bcabd-4230-416b-9c19-a96f4293c868", "c6c9a331-caef-43a2-80cd-733b143d6913" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29b3b632-c944-4d41-a804-95f90983ffa7", "5929d419-aba8-464a-a8c6-1afd7ff86aa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd41cd49-a27a-4e92-8acf-ef0b5b8d25f9", "e130543f-52a0-4b3c-92dc-2f7a260944e0" });
        }
    }
}
