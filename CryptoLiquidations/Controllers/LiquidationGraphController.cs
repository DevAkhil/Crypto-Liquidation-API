using CryptoLiquidations.Context;
using CryptoLiquidations.Methods;
using Microsoft.AspNetCore.Mvc;

namespace CryptoLiquidations.Controllers
{

    public class LiquidationGraphController : Controller
    {


        private readonly CryptoDbContext _cryptoDbContext;

        private readonly IConfiguration _configuration;

        private readonly IWebHostEnvironment _environment;

        ImageToAPI ia = new ImageToAPI();

        public LiquidationGraphController(CryptoDbContext context, IConfiguration configuration, IWebHostEnvironment environment)
        {
            _cryptoDbContext = context;
            _configuration = configuration;
            _environment = environment;





        }






        /// <summary>
        /// Returns a 24 hour graph of the liquidations that occurred
        /// </summary>
        /// <returns>A image/png Graph</returns>

        [HttpGet]
        [Route("Graph_24Hour")]
        public  ActionResult LiquidationGraph_24Hour()
        {
            byte[]? graph_24hour = ia.graphToByte("24hour", _environment);

            if(graph_24hour != null)
            {
                return File(graph_24hour, "image/png");
            }

            return NotFound();
        }

        /// <summary>
        /// Returns a 12 hour graph of the liquidations that occurred
        /// </summary>
        /// <returns>A image/png Graph</returns>
        [HttpGet]
        [Route("Graph_12Hour")]
        public ActionResult LiquidationGraph_12Hour()
        {
            byte[]? graph_12hour = ia.graphToByte("12hour", _environment);

            if (graph_12hour != null)
            {
                return File(graph_12hour, "image/png");
            }

            return NotFound();
        }

        /// <summary>
        /// Returns a 4 hour graph of the liquidations that occurred
        /// </summary>
        /// <returns>A image/png Graph</returns>
        [HttpGet]
        [Route("Graph_4Hour")]
        public ActionResult LiquidationGraph_4Hour()
        {
            byte[]? graph_4hour = ia.graphToByte("4hour", _environment);

            if (graph_4hour != null)
            {
                return File(graph_4hour, "image/png");
            }

            return NotFound();
        }

        /// <summary>
        /// Returns a 1 hour graph of the liquidations that occurred
        /// </summary>
        /// <returns>A image/png Graph</returns>
        [HttpGet]
        [Route("Graph_1Hour")]
        public ActionResult LiquidationGraph_1Hour()
        {
            byte[]? graph_1hour = ia.graphToByte("1hour", _environment);

            if (graph_1hour != null)
            {
                return File(graph_1hour, "image/png");
            }

            return NotFound();
        }

    }
}
