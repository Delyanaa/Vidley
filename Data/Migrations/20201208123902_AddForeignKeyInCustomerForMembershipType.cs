using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidley.Data.Migrations
{
    public partial class AddForeignKeyInCustomerForMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_MembershipType_MembershipTypeId",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_MembershipType_MembershipTypeId",
                table: "Customer",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_MembershipType_MembershipTypeId",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeId",
                table: "Customer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_MembershipType_MembershipTypeId",
                table: "Customer",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
