using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WartegAPI.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Food_FoodId",
                table: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Topping_FoodId",
                table: "Topping");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Topping");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topping",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Food",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ToppingId",
                table: "Food",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToppingId",
                table: "Food");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Topping",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Food",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topping_FoodId",
                table: "Topping",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_Food_FoodId",
                table: "Topping",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "FoodId");
        }
    }
}
