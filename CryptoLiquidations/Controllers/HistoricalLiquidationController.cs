using CryptoLiquidations.Context;
using CryptoLiquidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace CryptoLiquidations.Controllers
{


    public class HistoricalLiquidationController : Controller
    {
        private readonly CryptoDbContext _cryptoDbContext;

        private readonly IConfiguration _configuration;

        private readonly IWebHostEnvironment _environment;



        public HistoricalLiquidationController(CryptoDbContext context, IConfiguration configuration, IWebHostEnvironment environment)
        {
            _cryptoDbContext = context;
            _configuration = configuration;
            _environment = environment;





        }

        /// <summary>
        /// Returns the latest single historical liquidation
        /// </summary>
        /// <returns>A liquidation summary</returns>
        [HttpGet]
        [Route("LatestHistoricalLiquidation")]
        public ActionResult<HistoricalLiquidations> LatestHisoricalLiquidation()
        {

            if(_cryptoDbContext.HistoricalLiquidations != null)
            {
                var latestHL = _cryptoDbContext.HistoricalLiquidations.OrderByDescending(p => p.HL_ID).FirstOrDefault();
                if (latestHL == null)
                {
                    return NotFound();
                }
                return latestHL;

            }
            else
            {
                return NotFound();
            }





        }

        /// <summary>
        /// Returns a list of historical liquidations
        /// </summary>
        /// <returns>A list of liquidations</returns>
        [HttpGet]
        [Route("AllHistoricalLiquidations")]
        public ActionResult<List<HistoricalLiquidations>> historicalLiquidations()
        {
   

   

            if (_cryptoDbContext.HistoricalLiquidations != null)
            {
                var allHL = _cryptoDbContext.HistoricalLiquidations.OrderByDescending(p => p.HL_ID).ToList();
                if (allHL == null)
                {
                    return NotFound();
                }
                return allHL;

            }
            else
            {
                return NotFound();
            }




        }




    }
}
