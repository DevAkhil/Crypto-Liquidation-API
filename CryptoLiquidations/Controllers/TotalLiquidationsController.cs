using CryptoLiquidations.Context;
using CryptoLiquidations.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace CryptoLiquidations.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class TotalLiquidationsController : ControllerBase
    {

        private readonly CryptoDbContext _cryptoDbContext;

        private readonly IConfiguration _configuration;

        private readonly IWebHostEnvironment _environment;


        public TotalLiquidationsController(CryptoDbContext context, IConfiguration configuration, IWebHostEnvironment environment)
        {
            _cryptoDbContext = context;
            _configuration = configuration;
            _environment = environment;
       




        }

        /// <summary>
        /// Returns the latest liquidations in the past 1, 4, 12 and 24 hours
        /// </summary>
        /// <returns>The dollar amount liquidated</returns>
        [HttpGet]
        [Route("LatestLiquidations")]
        public ActionResult<LiquidationData> GetLatestLiquidation()
        {
        
            if (_cryptoDbContext.Liquidations != null)
            {
                var liquidations = _cryptoDbContext.Liquidations.OrderByDescending(p => p.LD_ID).FirstOrDefault();

                if (liquidations == null)
                {
                    return BadRequest();
                }
                else
                {
                    return liquidations;
                }

            }
            else
            {
                return BadRequest();
            }

            

            



        


        }




    }
}
