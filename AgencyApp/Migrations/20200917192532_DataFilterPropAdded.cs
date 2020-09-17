using Microsoft.EntityFrameworkCore.Migrations;

namespace AgencyApp.Migrations
{
    public partial class DataFilterPropAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataFilter",
                table: "PortfolioCategories",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFilter",
                table: "PortfolioCategories");
        }
    }
}
