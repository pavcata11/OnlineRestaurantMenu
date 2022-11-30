using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRestaurantMenu.Infrastructure.Migrations
{
    public partial class AddImageInFoodTypeAndDrinkType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "FoodTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "DrinkTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "FoodTypes");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "DrinkTypes");
        }
    }
}
