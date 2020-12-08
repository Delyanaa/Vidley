using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidley.Data.Migrations
{
    public partial class AddIsSubscribeAndMembershipTypeToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribeToNewsletter",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignUpFee = table.Column<short>(type: "smallint", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: false),
                    DurationInMonths = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_MembershipTypeId",
                table: "Customer",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_MembershipType_MembershipTypeId",
                table: "Customer",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_MembershipType_MembershipTypeId",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "MembershipType");

            migrationBuilder.DropIndex(
                name: "IX_Customer_MembershipTypeId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IsSubscribeToNewsletter",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "Customer");
        }
    }
}
