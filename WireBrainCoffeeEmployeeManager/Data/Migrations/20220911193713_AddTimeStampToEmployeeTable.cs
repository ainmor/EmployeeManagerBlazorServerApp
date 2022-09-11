using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WireBrainCoffeeEmployeeManager.Data.Migrations
{
    public partial class AddTimeStampToEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Timestamp",
                table: "Employees",
                type: "tinyint",
                rowVersion: true,
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Employees");
        }
    }
}
