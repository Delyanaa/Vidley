using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidley.Data.Migrations
{
    public partial class PopulatingMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT MembershipTypes ON");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DiscountRate, DurationInMonths) VALUES (1,0,0,0)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DiscountRate, DurationInMonths) VALUES (2,30,1,10)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DiscountRate, DurationInMonths) VALUES (3,90,3,15)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DiscountRate, DurationInMonths) VALUES (4,300,12,20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
