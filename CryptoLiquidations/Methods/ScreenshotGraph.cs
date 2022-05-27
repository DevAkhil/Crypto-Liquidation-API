using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;

namespace CryptoLiquidations.Models
{
    public class ScreenshotGraph
    {
    

        public LiquidationGraph getGraphScreenshots(LiquidationGraph lg, IWebDriver Driver, IWebHostEnvironment _environment)
        {
            if(lg == null)
            {
                lg = new LiquidationGraph();
            }

       
            lg.LG_Time = DateTime.Now.ToString();



            string xpath24hour = "/html/body/div[2]/div/div/div/div[2]/div[1]/div/div/div[1]";
            string filePath_24Hour = generateFilePath(_environment, "24hour");
            captureGraphScreenshot(Driver, "ALL", xpath24hour, filePath_24Hour, _environment);
            lg.LG_12HourGraph = filePath_24Hour;

            string xpath12hour = "/html/body/div[2]/div/div/div/div[2]/div[1]/div/div/div[8]";
            string filePath_12Hour = generateFilePath(_environment, "12hour");
            captureGraphScreenshot(Driver, "12 hours", xpath12hour, filePath_12Hour, _environment);
            lg.LG_12HourGraph = filePath_12Hour;


            string xpath4hour = "/html/body/div[2]/div/div/div/div[2]/div[1]/div/div/div[7]";
            string filePath_4Hour = generateFilePath(_environment, "4hour");
            captureGraphScreenshot(Driver, "4 hours", xpath4hour, "4hour", _environment);
            lg.LG_4HourGraph = filePath_4Hour;


            string xpath1hour = "/html/body/div[2]/div/div/div/div[2]/div[1]/div/div/div[6]";
            string filePath_1Hour = generateFilePath(_environment, "1hour");
            captureGraphScreenshot(Driver, "1 hour", xpath1hour, "1hour", _environment);
            lg.LG_1HourGraph = filePath_1Hour;



            return lg;
        }


        public void captureGraphScreenshot(IWebDriver Driver, string timeFrame, string xpath,  string filePath, IWebHostEnvironment _environment)
        {
            var graph = By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[2]");
            IWebElement dropDown = Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[4]/div[2]/div[2]/div/div[1]/div[2]/div/div[2]/div[2]"));
            changeGraphTimeframe(Driver, dropDown, timeFrame, xpath);
            Thread.Sleep(30000);

            VerticalCombineDecorator vcd = new VerticalCombineDecorator(new ScreenshotMaker());
            var screenMaker = new ScreenshotMaker();
            var onlyGraph = new OnlyElementDecorator(screenMaker);
            onlyGraph.SetElement(graph);
            Driver.TakeScreenshot(onlyGraph).ToMagickImage().Write(filePath, ImageMagick.MagickFormat.Png);

        }
        public bool hasClass(IWebElement element, string theClass)
        {
            return (" " + element.GetAttribute("class") + " ").Contains(" " + theClass + " ");
        }

        public bool isDropDownOpen(IWebElement dropDown)
        {
            if (hasClass(dropDown, "ant-select-open"))
            {
                return true;
            }

            return false;
        }

        public void changeGraphTimeframe(IWebDriver Driver, IWebElement dropDown, string nextTimeFrame,  string nextTimeFrameXpath)
        {
            while (dropDown.Text != nextTimeFrame)
            {

                try
                {

                    Console.WriteLine("Current Timeframe: " + dropDown.Text);
                    if (!isDropDownOpen(dropDown))
                    {
                        dropDown.Click();
                    }

                    Driver.FindElement(By.XPath(nextTimeFrameXpath)).Click();
                    Console.WriteLine("After Selected Timeframe: " + dropDown.Text);
                }
                catch (ElementClickInterceptedException e)
                {
                    var error = e.Message;
                    Console.WriteLine("Time Frame Not Found: Retrying... ");
                }


            }


        }

        public string generateFilePath(IWebHostEnvironment _environment, string fileName)
        {
            var path = _environment.WebRootPath + "\\Graphs\\";


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path + fileName + ".png";
        }

    }
}
