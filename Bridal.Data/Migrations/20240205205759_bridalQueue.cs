using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bridal.Data.Migrations
{
    public partial class bridalQueue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BridalList_DressmakerList_dressmakerId",
                table: "BridalList");

            migrationBuilder.DropForeignKey(
                name: "FK_QueueBridalList_BridalList_bridalId",
                table: "QueueBridalList");

            migrationBuilder.RenameColumn(
                name: "bridalId",
                table: "QueueBridalList",
                newName: "BridalId");

            migrationBuilder.RenameIndex(
                name: "IX_QueueBridalList_bridalId",
                table: "QueueBridalList",
                newName: "IX_QueueBridalList_BridalId");

            migrationBuilder.RenameColumn(
                name: "dressmakerId",
                table: "BridalList",
                newName: "DressmakerId");

            migrationBuilder.RenameIndex(
                name: "IX_BridalList_dressmakerId",
                table: "BridalList",
                newName: "IX_BridalList_DressmakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BridalList_DressmakerList_DressmakerId",
                table: "BridalList",
                column: "DressmakerId",
                principalTable: "DressmakerList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QueueBridalList_BridalList_BridalId",
                table: "QueueBridalList",
                column: "BridalId",
                principalTable: "BridalList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BridalList_DressmakerList_DressmakerId",
                table: "BridalList");

            migrationBuilder.DropForeignKey(
                name: "FK_QueueBridalList_BridalList_BridalId",
                table: "QueueBridalList");

            migrationBuilder.RenameColumn(
                name: "BridalId",
                table: "QueueBridalList",
                newName: "bridalId");

            migrationBuilder.RenameIndex(
                name: "IX_QueueBridalList_BridalId",
                table: "QueueBridalList",
                newName: "IX_QueueBridalList_bridalId");

            migrationBuilder.RenameColumn(
                name: "DressmakerId",
                table: "BridalList",
                newName: "dressmakerId");

            migrationBuilder.RenameIndex(
                name: "IX_BridalList_DressmakerId",
                table: "BridalList",
                newName: "IX_BridalList_dressmakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BridalList_DressmakerList_dressmakerId",
                table: "BridalList",
                column: "dressmakerId",
                principalTable: "DressmakerList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QueueBridalList_BridalList_bridalId",
                table: "QueueBridalList",
                column: "bridalId",
                principalTable: "BridalList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
