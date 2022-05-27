using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoLiquidations.Models
{
    public class LiquidationData
    {

        [Key]
        public int LD_ID { get; set; }

      
        public string? LD_Time { get; set; } = DateTime.Now.ToShortTimeString();

        public string? LD_1HrLiquidation { get; set; }
        public string? LD_4HrLiquidation { get; set; }
        public string? LD_12HrLiquidation { get; set; }
        public string? LD_24HrLiquidation { get; set; }

        public string? LD_TotalLiquidations { get; set; }

        public string? LD_LargestSingleLiquidation { get; set; }





    }
}
