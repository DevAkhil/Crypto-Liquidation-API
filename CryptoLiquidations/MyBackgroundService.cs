using CryptoLiquidations.Context;
using CryptoLiquidations.Methods;
using CryptoLiquidations.Models;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Drawing;

namespace CryptoLiquidations
{
    public class MyBackgroundService : BackgroundService
    {
        private readonly ILogger<MyBackgroundService> _logger;

        private IWebHostEnvironment _webHostEnvironment;
      
        public IServiceProvider Services { get; set; }

        public IWebDriver? Driver;
        public IList<LiquidationData>? ldList;
        public MyBackgroundService(ILogger<MyBackgroundService> logger, IServiceProvider services, IWebHostEnvironment webHostEnvironment)
        {

            Services = services;

            _logger = logger;

            _webHostEnvironment = webHostEnvironment;

            SeleniumFunctions sf = new SeleniumFunctions();

            Driver = sf.executeChromeBrowser(webHostEnvironment);

            sf.removeAdverts(Driver);
        }

     
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

  


            while (!stoppingToken.IsCancellationRequested)
            {
                if(Driver == null)
                {
                    break;
                }
                var liquidations = new LiquidationData();

                Driver.Navigate().Refresh();

                try
                {
                    TotalLiquidations lt = new TotalLiquidations();
                    HistoricalLiquidations hl = new HistoricalLiquidations();
                    HistoricalLiquidationsFunctions hlf = new HistoricalLiquidationsFunctions();
              
                    liquidations = lt.captureTotalLiquidations(Driver);

                    hl =  hlf.captureHistoricalLiquidations(Driver);

                    hlf.printHistoricalLiquidations(hl);


                    using (var scope = Services.CreateScope())
                    {
                        var context = scope.ServiceProvider.GetService<CryptoDbContext>();

                        if (context == null)
                        {
                            break;
                        }

                        LiquidationGraph lg = new LiquidationGraph();
                        if (context.LiquidationGraphs!= null)
                        {
                            lg = context.LiquidationGraphs.FirstOrDefault();
                        }
                         
               
                        

                        ScreenshotGraph sg = new ScreenshotGraph();

                        lg = sg.getGraphScreenshots(lg, Driver, _webHostEnvironment);

                        var lastEntry = context.HistoricalLiquidations.OrderBy(i => i.HL_ID).LastOrDefault();

                        if(lastEntry != null)
                        {
                            if (lastEntry.HL_Site == hl.HL_Site && lastEntry.HL_Time == hl.HL_Time && lastEntry.HL_QuantityInCrypto == hl.HL_QuantityInCrypto)
                            {
                                Console.WriteLine("Awaiting New Historical Liquidation");
                            }
                            else
                            {
                                context.HistoricalLiquidations.Add(hl);
                                Console.WriteLine("New Historical Liquidation Added");
                            }
                        }
                        else
                        {
                            context.HistoricalLiquidations.Add(hl);
                        }

                        context.LiquidationGraphs.Update(lg);

                        context.Liquidations.Add(liquidations);

                        context.SaveChanges();

                    }


                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }

                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

                

            }
          
         
        }
    }
}
