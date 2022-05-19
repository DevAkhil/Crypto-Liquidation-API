using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoLiquidations.Migrations
{
    public partial class AddedHistoricalLiquidations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricalLiquidations",
                columns: table => new
                {
                    HL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HL_Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HL_Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HL_Pair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HL_QuanityInDollars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HL_QuanitityInCrypto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HL_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HL_PositionType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalLiquidations", x => x.HL_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricalLiquidations");
        }
    }
}
