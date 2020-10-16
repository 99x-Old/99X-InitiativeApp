using Microsoft.EntityFrameworkCore.Migrations;

namespace InitiativeApp.API.Migrations
{
    public partial class UpdatedDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewCycle_Initiatives_InitiativeId",
                table: "ReviewCycle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewCycle",
                table: "ReviewCycle");

            migrationBuilder.RenameTable(
                name: "ReviewCycle",
                newName: "ReviewCycles");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewCycle_InitiativeId",
                table: "ReviewCycles",
                newName: "IX_ReviewCycles_InitiativeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewCycles",
                table: "ReviewCycles",
                column: "ReviewCycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewCycles_Initiatives_InitiativeId",
                table: "ReviewCycles",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewCycles_Initiatives_InitiativeId",
                table: "ReviewCycles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewCycles",
                table: "ReviewCycles");

            migrationBuilder.RenameTable(
                name: "ReviewCycles",
                newName: "ReviewCycle");

            migrationBuilder.RenameIndex(
                name: "IX_ReviewCycles_InitiativeId",
                table: "ReviewCycle",
                newName: "IX_ReviewCycle_InitiativeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewCycle",
                table: "ReviewCycle",
                column: "ReviewCycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewCycle_Initiatives_InitiativeId",
                table: "ReviewCycle",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
