using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bridal.Data.Migrations
{
    public partial class Bridal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DressmakerId",
                table: "BridalList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DressmakerId",
                table: "BridalList");
        }
    }
}
