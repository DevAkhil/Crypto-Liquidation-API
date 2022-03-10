using CryptoLiquidations.Context;
using CryptoLiquidations.Models;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CryptoLiquidations
{
    public class MyBackgroundService : BackgroundService
    {
        private readonly ILogger<MyBackgroundService> _logger;


      
        public IServiceProvider Services { get; set; }

        public IWebDriver? Driver;
        public IList<LiquadationData>? ldList;
        public MyBackgroundService(ILogger<MyBackgroundService> logger, IServiceProvider services)
        {

            Services = services;

            _logger = logger;

     

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://www.coinglass.com/LiquidationData");
        }

     
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

  


            while (!stoppingToken.IsCancellationRequested)
            {

                var liquidations = new LiquadationData();




                liquidations.LD_1HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[3]/div[1]/div/div[2]/div[1]/div[3]/span")).Text;

                liquidations.LD_4HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[3]/div[1]/div/div[2]/div[2]/div[3]/span")).Text;

                liquidations.LD_12HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[3]/div[1]/div/div[2]/div[3]/div[3]/span")).Text;

                liquidations.LD_24HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[3]/div[1]/div/div[2]/div[4]/div[3]/span")).Text;




                Console.WriteLine(liquidations);

                using (var scope = Services.CreateScope())
                {
                    var context = scope.ServiceProvider.GetService<CryptoDbContext>();


                    context.Liquidations.Add(liquidations);

                    context.SaveChanges();

                }


                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

                

            }
          
         
        }
    }
}
