using CryptoLiquidations.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoLiquidations.Context
{
    public class CryptoDbContext : DbContext
    {
        public CryptoDbContext(DbContextOptions<CryptoDbContext> options) : base(options)
        {

        }

        public DbSet<LiquidationData>? Liquidations { get; set; }
        public DbSet<SymbolLiquidationData>? SymbolLiquidations { get; set; }
        public DbSet<HistoricalLiquidations>? HistoricalLiquidations { get; set; }
        public DbSet<LiquidationGraph>? LiquidationGraphs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
