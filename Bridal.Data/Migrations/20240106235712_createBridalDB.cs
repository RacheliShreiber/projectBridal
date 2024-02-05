using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bridal.Data.Migrations
{
    public partial class createBridalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DressmakerList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressmakerList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BridalList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateWedding = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dressmakerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BridalList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BridalList_DressmakerList_dressmakerId",
                        column: x => x.dressmakerId,
                        principalTable: "DressmakerList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QueueBridalList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bridalId = table.Column<int>(type: "int", nullable: false),
                    DateQueue = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueBridalList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueueBridalList_BridalList_bridalId",
                        column: x => x.bridalId,
                        principalTable: "BridalList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BridalList_dressmakerId",
                table: "BridalList",
                column: "dressmakerId");

            migrationBuilder.CreateIndex(
                name: "IX_QueueBridalList_bridalId",
                table: "QueueBridalList",
                column: "bridalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QueueBridalList");

            migrationBuilder.DropTable(
                name: "BridalList");

            migrationBuilder.DropTable(
                name: "DressmakerList");
        }
    }
}
