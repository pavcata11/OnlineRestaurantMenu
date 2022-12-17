using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRestaurantMenu.Infrastructure.Migrations
{
    public partial class addProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "273453f5-390b-4083-8777-b2ff319a8edb", "d857c935-a9e0-4471-b5e0-b288899b637f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "464e9ce2-e761-4afe-844f-8727877c0abc", "09203e02-a4f7-45f9-9e25-aa77ef74e62e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2111af1e-6bf6-4e5c-89a1-29f442158291", "2b24d6c6-d521-4079-ad04-05d6e4eb65dc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://cdncloudcart.com/16474/products/images/2280/koka-kola-ken-330ml-image_5f5641fd58685_600x600.jpeg?1599488528");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "Description", "Image", "Name", "Price", "ProductSecondaryTypeId" },
                values: new object[] { 80, "Описание на фанта портокал някакъв текст", "https://distribution-eu.com/wp-content/uploads/2021/05/Fanta-Orange.jpg", "Фанта портокал", 3m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calories", "Description", "Image", "Name", "Price", "ProductSecondaryTypeId", "Size", "TimeToget" },
                values: new object[,]
                {
                    { 4, 254, "Описание на Cappy Вишна някакъв текст", "https://bai-ilia.com/image/cache/data/kapi-vishna-0250l-kasa55-0-800x800.jpg", "Cappy Вишна", 3m, 5, 250, 3 },
                    { 5, 254, "Описание на Cappy портокал някакъв текст", "https://sofia.parkmart.bg/wp-content/uploads/2022/05/0000023548.jpg", "Cappy портокал", 3m, 5, 250, 3 },
                    { 6, 450, "Описание на овчарска салата", "https://gradcontent.com/lib/400x296/mozarella29.jpg", "Овчарска салата", 9.45m, 2, 250, 32 },
                    { 7, 450, "Описание на Цезар салата", "https://matekitchen.com/wp-content/uploads/2021/12/salata-tsezar-s-pile-i-krutoni.jpg", "Салата Цезар", 9.45m, 2, 250, 20 },
                    { 8, 450, "Руска салата", "https://www.supichka.com/files/images/2757/klasicheska_ruska_salata_1.jpg", "Салата Цезар", 9.45m, 2, 250, 20 }
                });

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 14, 19, 41, 10, 726, DateTimeKind.Local).AddTicks(2565));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "Description", "Image", "Name", "Price", "ProductSecondaryTypeId" },
                values: new object[] { 450, "Описание на овчарска салата", "https://www.foodbusinessafrica.com/wp-content/uploads/2021/08/soda.jpg", "Овчарска салата", 9.45m, 2 });

            migrationBuilder.UpdateData(
                table: "Waiters",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStartWork",
                value: new DateTime(2022, 12, 14, 19, 15, 53, 999, DateTimeKind.Local).AddTicks(17));
        }
    }
}
