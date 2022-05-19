using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoLiquidations.Migrations
{
    public partial class EditedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HL_QuanityInDollars",
                table: "HistoricalLiquidations",
                newName: "HL_QuantityInDollars");

            migrationBuilder.RenameColumn(
                name: "HL_QuanitityInCrypto",
                table: "HistoricalLiquidations",
                newName: "HL_QuantityInCrypto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HL_QuantityInDollars",
                table: "HistoricalLiquidations",
                newName: "HL_QuanityInDollars");

            migrationBuilder.RenameColumn(
                name: "HL_QuantityInCrypto",
                table: "HistoricalLiquidations",
                newName: "HL_QuanitityInCrypto");
        }
    }
}
