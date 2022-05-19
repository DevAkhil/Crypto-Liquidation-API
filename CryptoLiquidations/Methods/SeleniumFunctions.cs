using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace CryptoLiquidations.Methods
{
    public class SeleniumFunctions
    {
        public IWebDriver executeChromeBrowser()
        {
            IWebDriver Driver;
             ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddAdditionalCapability("resolution", "1920x1080", true);
            chromeOptions.AddArgument("--headless");

            Driver = new ChromeDriver(chromeOptions);

            Driver.Navigate().GoToUrl("https://www.coinglass.com/LiquidationData");

    
            Driver.Manage().Window.Position = new Point(0, 0);
            Driver.Manage().Window.Size = new Size(1920, 1080);

            return Driver;

        }

        public void removeAdverts(IWebDriver Driver)
        {

            try
            {
                Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[1]/div/span")).Click();

            }
            catch (Exception e)
            {
                Console.WriteLine("Ad Not Found: " + e.Message);
            }

        }

    }
}
