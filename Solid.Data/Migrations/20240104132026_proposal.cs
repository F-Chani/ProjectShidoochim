using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class proposal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proposal_matchmakers_matchmakerId",
                table: "proposal");

            migrationBuilder.RenameColumn(
                name: "matchmakerId",
                table: "proposal",
                newName: "MatchmakerId");

            migrationBuilder.RenameIndex(
                name: "IX_proposal_matchmakerId",
                table: "proposal",
                newName: "IX_proposal_MatchmakerId");

            migrationBuilder.AlterColumn<int>(
                name: "MatchmakerId",
                table: "proposal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_proposal_matchmakers_MatchmakerId",
                table: "proposal",
                column: "MatchmakerId",
                principalTable: "matchmakers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proposal_matchmakers_MatchmakerId",
                table: "proposal");

            migrationBuilder.RenameColumn(
                name: "MatchmakerId",
                table: "proposal",
                newName: "matchmakerId");

            migrationBuilder.RenameIndex(
                name: "IX_proposal_MatchmakerId",
                table: "proposal",
                newName: "IX_proposal_matchmakerId");

            migrationBuilder.AlterColumn<int>(
                name: "matchmakerId",
                table: "proposal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_proposal_matchmakers_matchmakerId",
                table: "proposal",
                column: "matchmakerId",
                principalTable: "matchmakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
