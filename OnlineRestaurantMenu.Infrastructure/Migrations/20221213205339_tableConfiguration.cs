using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRestaurantMenu.Infrastructure.Migrations
{
    public partial class tableConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f9da483-94d5-409b-94f1-4b720bd0faf4", "709ec14e-c117-494e-bade-288f9fe19b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80d078dd-ca0a-431e-81b6-ca3a2018fde8", "867eed6e-cb07-419f-be68-9f449c512381" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2270e95-f008-423a-b600-5cba28913d12", "7e76cee5-59fd-4c3c-acf3-6c146bbd1c9b" });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "CountOfSeats", "Description", "Number", "TableStatus", "WaiterId" },
                values: new object[,]
                {
                    { 1, 4, "Масата се намира на до прозореца", 1, 0, 1 },
                    { 2, 5, "Втората маса до прозореца", 2, 0, 1 },
                    { 3, 10, "Централната маса в първа зала", 3, 0, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 13, 22, 53, 39, 469, DateTimeKind.Local).AddTicks(1881));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 13, 22, 50, 39, 671, DateTimeKind.Local).AddTicks(3467));
        }
    }
}
