using Microsoft.EntityFrameworkCore.Migrations;

namespace ZensHomeDotNetCore.Migrations
{
    public partial class _5th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "VillageConsumption");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VillageConsumption",
                type: "text",
                nullable: true);
        }
    }
}
