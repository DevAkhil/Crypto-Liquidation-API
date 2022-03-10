using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CryptoLiquidations.Models
{

    public class Selenium : ControllerBase
    {
        public IWebDriver? Driver;
        public Selenium()
        {
            if(Driver == null)
            {
     

                    Driver = new ChromeDriver();

                    Driver.Navigate().GoToUrl("https://www.coinglass.com/LiquidationData");


            }



        }



    }









}
