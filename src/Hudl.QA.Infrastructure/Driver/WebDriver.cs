using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Hudl.QA.Infrastructure.Driver
{
    /// <summary>
    /// Manages a browser instance using Selenium
    /// </summary>
    public class WebDriver 
    {
        /// <summary>
        /// The interface of driver.
        /// </summary>
        private static IWebDriver webDriver;

        public static IWebDriver GetDriver()
        {
            if (webDriver == null)
            {
                webDriver = GetChromeDriver();
            }

            return webDriver;
        }

        public static void Quit()
        {
            if (webDriver == null)
            {
                return;
            }

            try
            {
                webDriver.Quit();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            webDriver = null;
        }

        private static IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            var driver = new ChromeDriver(options);
            return driver;
        }
    }
}
