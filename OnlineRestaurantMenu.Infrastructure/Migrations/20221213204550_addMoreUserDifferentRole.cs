using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRestaurantMenu.Infrastructure.Migrations
{
    public partial class addMoreUserDifferentRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd41cd49-a27a-4e92-8acf-ef0b5b8d25f9", "e130543f-52a0-4b3c-92dc-2f7a260944e0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4b7f2886-0c38-41b3-8281-b6fc1f465838", 0, 0, "2d3bcabd-4230-416b-9c19-a96f4293c868", "daniel@gmail.com", false, "Daniel", "Ivanchev", false, null, null, null, null, null, false, "c6c9a331-caef-43a2-80cd-733b143d6913", false, "Daniel" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5176633b-6d3f-405f-8f75-adc61261d6d3", 0, 0, "29b3b632-c944-4d41-a804-95f90983ffa7", "pavel@gmail.com", false, "Pavel", "Ivanchev", false, null, null, null, null, null, false, "5929d419-aba8-464a-a8c6-1afd7ff86aa6", false, "Pavel" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8572e5a7-c0cb-4b91-a456-ecf092ac4e81", "4b7f2886-0c38-41b3-8281-b6fc1f465838" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "5176633b-6d3f-405f-8f75-adc61261d6d3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8572e5a7-c0cb-4b91-a456-ecf092ac4e81", "4b7f2886-0c38-41b3-8281-b6fc1f465838" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "5176633b-6d3f-405f-8f75-adc61261d6d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b7f2886-0c38-41b3-8281-b6fc1f465838");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5176633b-6d3f-405f-8f75-adc61261d6d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46cfaf7d-9c6b-4102-87b3-a3517f55aeaa", "bbe4723d-17b9-4053-aee3-57906cf18c3d" });
        }
    }
}
