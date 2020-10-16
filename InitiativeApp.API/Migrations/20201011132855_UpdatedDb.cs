using Microsoft.EntityFrameworkCore.Migrations;

namespace InitiativeApp.API.Migrations
{
    public partial class UpdatedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Initiatives_InitiativeId",
                table: "Meeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meeting",
                table: "Meeting");

            migrationBuilder.RenameTable(
                name: "Meeting",
                newName: "Meetings");

            migrationBuilder.RenameIndex(
                name: "IX_Meeting_InitiativeId",
                table: "Meetings",
                newName: "IX_Meetings_InitiativeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings");

            migrationBuilder.RenameTable(
                name: "Meetings",
                newName: "Meeting");

            migrationBuilder.RenameIndex(
                name: "IX_Meetings_InitiativeId",
                table: "Meeting",
                newName: "IX_Meeting_InitiativeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meeting",
                table: "Meeting",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Initiatives_InitiativeId",
                table: "Meeting",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
