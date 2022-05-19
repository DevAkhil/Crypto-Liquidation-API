using CryptoLiquidations.Models;
using OpenQA.Selenium;

namespace CryptoLiquidations.Methods
{
    public class TotalLiquidations
    {

        public LiquidationData captureTotalLiquidations(IWebDriver Driver)
        {
            LiquidationData liquidations = new LiquidationData();   
            liquidations.LD_1HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[1]/div/div[2]/div[1]/div[3]/span")).Text;

            liquidations.LD_4HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[1]/div/div[2]/div[2]/div[3]/span")).Text;

            liquidations.LD_12HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[1]/div/div[2]/div[3]/div[3]/span")).Text;

            liquidations.LD_24HrLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[1]/div/div[2]/div[4]/div[3]/span")).Text;

            liquidations.LD_TotalLiquidations = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[1]/div/div[3]/div[1]")).Text;

            liquidations.LD_LargestSingleLiquidation = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[1]/div/div[3]/div[2]")).Text;

            printLiquidationData(liquidations);


            return liquidations;
        }

        public void printLiquidationData(LiquidationData liquidations)
        {
            Console.WriteLine("Time: " + DateTime.Now);
            Console.WriteLine("Last 1 Hour Liquidation: " + liquidations.LD_1HrLiquidation);
            Console.WriteLine("Last 4 Hour Liquidation: " + liquidations.LD_4HrLiquidation);
            Console.WriteLine("Last 12 Hour Liquidation: " + liquidations.LD_12HrLiquidation);
            Console.WriteLine("Last 24 Hour Liquidation: " + liquidations.LD_24HrLiquidation);
            Console.WriteLine("Total Liquidations: " + liquidations.LD_TotalLiquidations);
            Console.WriteLine("Largest Single Liquidation: " + liquidations.LD_LargestSingleLiquidation);
            Console.WriteLine("---------------------------------------------------");

        }


    }
}
