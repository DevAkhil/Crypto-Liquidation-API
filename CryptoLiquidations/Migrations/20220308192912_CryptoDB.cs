using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoLiquidations.Migrations
{
    public partial class CryptoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Liquidations",
                columns: table => new
                {
                    LD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LD_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LD_1HrLiquidation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LD_4HrLiquidation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LD_12HrLiquidation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LD_24HrLiquidation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidations", x => x.LD_ID);
                });

            migrationBuilder.CreateTable(
                name: "SymbolLiquidations",
                columns: table => new
                {
                    SLD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SLD_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SLD_LiquidationInDollars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLD_LiquidationInCrypto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymbolLiquidations", x => x.SLD_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Liquidations");

            migrationBuilder.DropTable(
                name: "SymbolLiquidations");
        }
    }
}
