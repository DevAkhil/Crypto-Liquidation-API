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
    public class CryptoController : ControllerBase
    {

        private readonly CryptoDbContext _cryptoDbContext;

        private readonly IConfiguration _configuration;


        public CryptoController(CryptoDbContext context, IConfiguration configuration)
        {
            _cryptoDbContext = context;
            _configuration = configuration;

       




        }


        [HttpGet]
        [Route("GetData")]
        public async Task<IActionResult> GetLatestLiquidation()
        {

            var liquidations = _cryptoDbContext.Liquidations.ToList();



            return Ok(liquidations.LastOrDefault());


        }





    }
}
