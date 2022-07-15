using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM_MovieRandomizer.Data.Migrations
{
    public partial class movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    OpeningWeekendSales = table.Column<double>(type: "float", nullable: false),
                    TotalSales = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "OpeningWeekendSales", "Rating", "ReleaseDate", "Title", "TotalSales" },
                values: new object[] { new Guid("f11ddda7-bb09-4d47-8da6-26f2065f15c8"), 345345345.0, 0, new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon: The First Movie", 34534534.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
