using CryptoLiquidations.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoLiquidations.Context
{
    public class CryptoDbContext : DbContext
    {
        public CryptoDbContext(DbContextOptions<CryptoDbContext> options) : base(options)
        {

        }

        public DbSet<LiquadationData>? Liquidations { get; set; }
        public DbSet<SymbolLiquidationData>? SymbolLiquidations { get; set; }

       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
