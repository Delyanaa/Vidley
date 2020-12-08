using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidley.Data.Migrations
{
    public partial class RenameColumnInCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birtday",
                table: "MembershipTypes",
                newName: "Birthday");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "MembershipTypes",
                newName: "Birtday");
        }
    }
}
