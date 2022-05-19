using System.ComponentModel.DataAnnotations;

namespace CryptoLiquidations.Models
{
    public class LiquidationGraph
    {
        [Key]
        public int LG_ID { get; set; }

        public string LG_Time { get; set; } = DateTime.Now.ToString();

        public string? LG_1HourGraph { get; set; }

        public string? LG_4HourGraph { get; set; }

        public string? LG_12HourGraph { get; set; }

        public string? LG_24HourGraph { get; set; }
    }
}
