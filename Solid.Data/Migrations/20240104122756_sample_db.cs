using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class sample_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "proposal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuyId = table.Column<int>(type: "int", nullable: false),
                    GirlId = table.Column<int>(type: "int", nullable: false),
                    matchmakerId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proposal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proposal_girls_GirlId",
                        column: x => x.GirlId,
                        principalTable: "girls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proposal_guys_GuyId",
                        column: x => x.GuyId,
                        principalTable: "guys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proposal_matchmakers_matchmakerId",
                        column: x => x.matchmakerId,
                        principalTable: "matchmakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_proposal_GirlId",
                table: "proposal",
                column: "GirlId");

            migrationBuilder.CreateIndex(
                name: "IX_proposal_GuyId",
                table: "proposal",
                column: "GuyId");

            migrationBuilder.CreateIndex(
                name: "IX_proposal_matchmakerId",
                table: "proposal",
                column: "matchmakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proposal");
        }
    }
}
