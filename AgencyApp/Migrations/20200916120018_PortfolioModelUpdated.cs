using Microsoft.EntityFrameworkCore.Migrations;

namespace AgencyApp.Migrations
{
    public partial class PortfolioModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "Portfolios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "Portfolios",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
