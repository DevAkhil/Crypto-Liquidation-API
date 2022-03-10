using System.ComponentModel.DataAnnotations;

namespace CryptoLiquidations.Models
{
    public class SymbolLiquidationData
    {

        [Key]
        public int SLD_ID { get; set; }

        public string SLD_Name { get; set; } = "";

        public string? SLD_LiquidationInDollars { get; set; }

        public string? SLD_LiquidationInCrypto { get; set; }




    }
}
