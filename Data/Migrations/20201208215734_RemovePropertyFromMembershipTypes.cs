using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidley.Data.Migrations
{
    public partial class RemovePropertyFromMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "MembershipTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "MembershipTypes",
                type: "datetime2",
                nullable: true);
        }
    }
}
