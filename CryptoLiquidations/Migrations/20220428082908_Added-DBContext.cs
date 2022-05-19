using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoLiquidations.Migrations
{
    public partial class AddedDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LiquidationGraphs",
                columns: table => new
                {
                    LG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LG_Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LG_1HourGraph = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LG_4HourGraph = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LG_12HourGraph = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidationGraphs", x => x.LG_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiquidationGraphs");
        }
    }
}
