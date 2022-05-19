using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoLiquidations.Migrations
{
    public partial class Added24Hour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LG_24HourGraph",
                table: "LiquidationGraphs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LG_24HourGraph",
                table: "LiquidationGraphs");
        }
    }
}
