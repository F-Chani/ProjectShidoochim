using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "girls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Heigh = table.Column<double>(type: "float", nullable: false),
                    Seminary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IfGiveFlat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_girls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "guys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Heigh = table.Column<double>(type: "float", nullable: false),
                    Yeshiva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IfGiveFlat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "matchmakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matchmakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "proposal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuyId = table.Column<int>(type: "int", nullable: false),
                    GirlId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatchmakerId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_proposal_matchmakers_MatchmakerId",
                        column: x => x.MatchmakerId,
                        principalTable: "matchmakers",
                        principalColumn: "Id");
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
                name: "IX_proposal_MatchmakerId",
                table: "proposal",
                column: "MatchmakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proposal");

            migrationBuilder.DropTable(
                name: "girls");

            migrationBuilder.DropTable(
                name: "guys");

            migrationBuilder.DropTable(
                name: "matchmakers");
        }
    }
}
