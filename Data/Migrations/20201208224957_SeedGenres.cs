using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidley.Data.Migrations
{
    public partial class SeedGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Genres ON");

            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2,'SiFi')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Horror')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4,'Action')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (5,'Other')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
