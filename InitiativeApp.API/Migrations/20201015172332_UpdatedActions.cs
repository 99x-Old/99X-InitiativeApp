using Microsoft.EntityFrameworkCore.Migrations;

namespace InitiativeApp.API.Migrations
{
    public partial class UpdatedActions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewCycles_Initiatives_InitiativeId",
                table: "ReviewCycles");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "InitiativeId",
                table: "ReviewCycles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InitiativeId",
                table: "Meetings",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IniiativeYear",
                table: "Initiatives",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewCycles_Initiatives_InitiativeId",
                table: "ReviewCycles",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewCycles_Initiatives_InitiativeId",
                table: "ReviewCycles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IniiativeYear",
                table: "Initiatives");

            migrationBuilder.AlterColumn<int>(
                name: "InitiativeId",
                table: "ReviewCycles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "InitiativeId",
                table: "Meetings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewCycles_Initiatives_InitiativeId",
                table: "ReviewCycles",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "InitiativeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
