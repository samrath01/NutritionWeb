using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace NutritionWeb.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vitamins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VitaminName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitamins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    VitaminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diseases_Vitamins_VitaminId",
                        column: x => x.VitaminId,
                        principalTable: "Vitamins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    VitaminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Vitamins_VitaminId",
                        column: x => x.VitaminId,
                        principalTable: "Vitamins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplementName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    VitaminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplements_Vitamins_VitaminId",
                        column: x => x.VitaminId,
                        principalTable: "Vitamins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_VitaminId",
                table: "Diseases",
                column: "VitaminId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_VitaminId",
                table: "Foods",
                column: "VitaminId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_VitaminId",
                table: "Supplements",
                column: "VitaminId");

            var sql = Path.Combine(".\\Data", @"backups.sql");
            migrationBuilder.Sql(File.ReadAllText(sql));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Supplements");

            migrationBuilder.DropTable(
                name: "Vitamins");
        }
    }
}
