using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameNight.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitalSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boardgames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdult = table.Column<bool>(type: "bit", nullable: false),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameType = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boardgames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardgameNights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizerId = table.Column<int>(type: "int", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdult = table.Column<bool>(type: "bit", nullable: false),
                    MaxParticipants = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoodAndDrinks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardgameNights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameNightBoardgames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardgameNightId = table.Column<int>(type: "int", nullable: false),
                    BoardgameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameNightBoardgames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameNightBoardgames_BoardgameNights_BoardgameNightId",
                        column: x => x.BoardgameNightId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameNightBoardgames_Boardgames_BoardgameId",
                        column: x => x.BoardgameId,
                        principalTable: "Boardgames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameNightReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ReviewDescription = table.Column<int>(type: "int", nullable: false),
                    BoardgameNightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameNightReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameNightReviews_BoardgameNights_BoardgameNightId",
                        column: x => x.BoardgameNightId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    BoardgameNightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_BoardgameNights_BoardgameNightId",
                        column: x => x.BoardgameNightId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardgameNights_OrganizerId",
                table: "BoardgameNights",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameNightBoardgames_BoardgameId",
                table: "GameNightBoardgames",
                column: "BoardgameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameNightBoardgames_BoardgameNightId",
                table: "GameNightBoardgames",
                column: "BoardgameNightId");

            migrationBuilder.CreateIndex(
                name: "IX_GameNightReviews_BoardgameNightId",
                table: "GameNightReviews",
                column: "BoardgameNightId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BoardgameNightId",
                table: "Users",
                column: "BoardgameNightId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardgameNights_Users_OrganizerId",
                table: "BoardgameNights",
                column: "OrganizerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardgameNights_Users_OrganizerId",
                table: "BoardgameNights");

            migrationBuilder.DropTable(
                name: "GameNightBoardgames");

            migrationBuilder.DropTable(
                name: "GameNightReviews");

            migrationBuilder.DropTable(
                name: "Boardgames");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BoardgameNights");
        }
    }
}
