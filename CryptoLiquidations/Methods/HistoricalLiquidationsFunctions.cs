using CryptoLiquidations.Models;
using OpenQA.Selenium;

namespace CryptoLiquidations.Methods
{
    public class HistoricalLiquidationsFunctions
    {

        public HistoricalLiquidations captureHistoricalLiquidations(IWebDriver Driver)
        {
            HistoricalLiquidations hl = new HistoricalLiquidations();

            //Driver.FindElement(By.XPath("")).Text;


            hl.HL_Site = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[1]/div/div")).Text;

            hl.HL_Time = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[2]/div/div[1]")).Text + " " + Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[2]/div/div[2]")).Text;

            hl.HL_Pair = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[3]/div")).Text;

            hl.HL_QuantityInDollars = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[4]/div/div[1]")).Text;

            hl.HL_QuantityInCrypto = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[4]/div/div[2]")).Text;

            hl.HL_Price = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[5]/div/div[1]")).Text;

            hl.HL_PositionType = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[3]/div/div[2]/div/div/div/div/div[2]/table/tbody/tr[2]/td[5]/div/div[2]")).Text;

            return hl;
        } 


        public void printHistoricalLiquidations(HistoricalLiquidations hl)
        {

            Console.WriteLine("Site: " + hl.HL_Site);
            Console.WriteLine("Time: " + hl.HL_Time);
            Console.WriteLine("Pair: " + hl.HL_Pair);
            Console.WriteLine("Quantity In Dollars: " + hl.HL_QuantityInDollars);
            Console.WriteLine("Quantity In Crypto: " + hl.HL_QuantityInCrypto);
            Console.WriteLine("Price: " + hl.HL_Price);

        }



    }
}
