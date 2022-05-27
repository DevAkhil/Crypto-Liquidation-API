using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CryptoLiquidations.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricalLiquidations",
                columns: table => new
                {
                    HL_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HL_Site = table.Column<string>(type: "text", nullable: true),
                    HL_Time = table.Column<string>(type: "text", nullable: true),
                    HL_Pair = table.Column<string>(type: "text", nullable: true),
                    HL_QuantityInDollars = table.Column<string>(type: "text", nullable: true),
                    HL_QuantityInCrypto = table.Column<string>(type: "text", nullable: true),
                    HL_Price = table.Column<string>(type: "text", nullable: true),
                    HL_PositionType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalLiquidations", x => x.HL_ID);
                });

            migrationBuilder.CreateTable(
                name: "LiquidationGraphs",
                columns: table => new
                {
                    LG_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LG_Time = table.Column<string>(type: "text", nullable: false),
                    LG_1HourGraph = table.Column<string>(type: "text", nullable: true),
                    LG_4HourGraph = table.Column<string>(type: "text", nullable: true),
                    LG_12HourGraph = table.Column<string>(type: "text", nullable: true),
                    LG_24HourGraph = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidationGraphs", x => x.LG_ID);
                });

            migrationBuilder.CreateTable(
                name: "Liquidations",
                columns: table => new
                {
                    LD_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LD_Time = table.Column<string>(type: "text", nullable: true),
                    LD_1HrLiquidation = table.Column<string>(type: "text", nullable: true),
                    LD_4HrLiquidation = table.Column<string>(type: "text", nullable: true),
                    LD_12HrLiquidation = table.Column<string>(type: "text", nullable: true),
                    LD_24HrLiquidation = table.Column<string>(type: "text", nullable: true),
                    LD_TotalLiquidations = table.Column<string>(type: "text", nullable: true),
                    LD_LargestSingleLiquidation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidations", x => x.LD_ID);
                });

            migrationBuilder.CreateTable(
                name: "SymbolLiquidations",
                columns: table => new
                {
                    SLD_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SLD_Name = table.Column<string>(type: "text", nullable: false),
                    SLD_LiquidationInDollars = table.Column<string>(type: "text", nullable: true),
                    SLD_LiquidationInCrypto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymbolLiquidations", x => x.SLD_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricalLiquidations");

            migrationBuilder.DropTable(
                name: "LiquidationGraphs");

            migrationBuilder.DropTable(
                name: "Liquidations");

            migrationBuilder.DropTable(
                name: "SymbolLiquidations");
        }
    }
}
