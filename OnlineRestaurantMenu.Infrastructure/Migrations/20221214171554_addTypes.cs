using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRestaurantMenu.Infrastructure.Migrations
{
    public partial class addTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f3aff17-83a3-43d9-9d53-822935950b6d", "e4b27bbe-62db-4d13-8545-04a6a5166c7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37580260-5d24-4ec7-b3b9-f0b7cda80567", "a8d98cce-6102-4045-9035-bd2f5b0dd2ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cd833bf-8872-4393-9cfc-bd7292b07d4c", "7db7bd48-9fc2-480e-826a-a3ce53fa3659" });

            migrationBuilder.UpdateData(
                table: "ProductSecondaryTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.acouplecooks.com/wp-content/uploads/2019/05/Chopped-Salad-001_1.jpg");

            migrationBuilder.InsertData(
                table: "ProductSecondaryTypes",
                columns: new[] { "Id", "Image", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 3, "https://raffyplovdiv.bg/files/images/578/fit_536_406.jpg", "Основни ястия", 2 },
                    { 4, "https://s.rozali.com/p/k/r/krem-supa-254088-500x0.jpg?1475569614483", "Супи", 2 },
                    { 5, "https://m.netinfo.bg/media/images/32836/32836858/991-ratio-sok-plodov-sok.jpg", "Сокове", 1 },
                    { 6, "https://cache2.24chasa.bg/Images/cache/281/Image_6207281_128_0.jpg", "Фрешове", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 14, 19, 15, 53, 999, DateTimeKind.Local).AddTicks(17));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductSecondaryTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSecondaryTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSecondaryTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSecondaryTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8621e4d-6209-4527-954a-2a3d1250824d", "88c64008-95bb-4d88-84f5-3fa2d52eec85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee6796a8-d31b-4b8f-91e3-24df95cfd79b", "80552e86-b0a8-4d28-b4ce-5fb785be8153" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9521e93-51d4-4627-b0e3-10c3bd25dd88", "0aa7dc62-33c9-4cc7-a001-dca1f57a80ba" });

            migrationBuilder.UpdateData(
                table: "ProductSecondaryTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg");

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 14, 19, 1, 5, 221, DateTimeKind.Local).AddTicks(3845));
        }
    }
}
