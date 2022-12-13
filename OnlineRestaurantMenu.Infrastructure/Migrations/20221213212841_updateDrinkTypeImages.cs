using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRestaurantMenu.Infrastructure.Migrations
{
    public partial class updateDrinkTypeImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ba4c3b6-19ac-42a1-9359-24bd49ecb082", "7401fe51-b73d-4fbc-93b3-3f6e6e3fb113" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d6f9a28-5538-4743-88ff-f34725e72bd7", "66091b47-56a6-4632-b326-9dc96790c2cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f192adb-66d7-4aa1-9410-ac464a6f4adc", "032e3b29-1063-41f5-9bd2-cac93ba69168" });

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 13, 23, 28, 40, 548, DateTimeKind.Local).AddTicks(5137));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be3d9258-d1be-4be0-a80e-3319aee30648", "70346da0-0d87-4ca1-aef8-768d32730bc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8b6b532-85a4-450f-811a-26fbdc822b62", "b03c8e88-3e84-4738-b8fb-6cc624700ee5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b453dc5a-2867-4b05-a1d4-3897474b65c6", "6f37057b-befc-4894-b1c1-b7075e604283" });

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 13, 23, 27, 30, 597, DateTimeKind.Local).AddTicks(2492));
        }
    }
}
