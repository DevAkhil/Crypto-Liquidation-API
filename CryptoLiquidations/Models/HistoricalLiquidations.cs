using System.ComponentModel.DataAnnotations;

namespace CryptoLiquidations.Models
{
    public class HistoricalLiquidations
    {
        [Key]
        public int HL_ID { get; set; }

        public string? HL_Site { get; set; }

        public string? HL_Time { get; set; }

        public string? HL_Pair { get; set; }

        public string? HL_QuantityInDollars { get; set; }

        public string? HL_QuantityInCrypto { get; set; }

        public string? HL_Price { get; set; }

        public string? HL_PositionType { get; set; }

    }
}
