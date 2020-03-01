using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZensHomeDotNetCore.Migrations
{
    public partial class _2ndmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricCounter_Village_VillageId",
                table: "ElectricCounter");

            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "Village",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "VillageId",
                table: "ElectricCounter",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricCounter_Village_VillageId",
                table: "ElectricCounter",
                column: "VillageId",
                principalTable: "Village",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricCounter_Village_VillageId",
                table: "ElectricCounter");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Village");

            migrationBuilder.AlterColumn<int>(
                name: "VillageId",
                table: "ElectricCounter",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricCounter_Village_VillageId",
                table: "ElectricCounter",
                column: "VillageId",
                principalTable: "Village",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
