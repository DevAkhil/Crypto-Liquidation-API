using System.ComponentModel.DataAnnotations;

namespace CryptoLiquidations.Models
{
    public class LiquadationData
    {

        [Key]
        public int LD_ID { get; set; }

        public DateTime LD_Time { get; set; } = DateTime.Now;

        public string LD_1HrLiquidation { get; set; }
        public string LD_4HrLiquidation { get; set; }
        public string LD_12HrLiquidation { get; set; }
        public string LD_24HrLiquidation { get; set; }





    }
}
