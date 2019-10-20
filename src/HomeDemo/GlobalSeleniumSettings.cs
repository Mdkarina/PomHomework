using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumTestsPOM
{
    public static class GlobalSeleniumSettings
    {
        public static IWebDriver DefaultDriver => ChromeDriver;

        public static IWebDriver SeleniumGridChromeDriver
        {
            get
            {
                string _nodeUrl = "http://10.0.4.46:39406/wd/hub";

                ChromeOptions options = new ChromeOptions();
                options.PlatformName = "WINDOWS";
                options.BrowserVersion = "77.0";

                var driver = new RemoteWebDriver(new Uri(_nodeUrl), options.ToCapabilities(), TimeSpan.FromSeconds(10));
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(100);

                return driver;
            }
        }

        public static IWebDriver ChromeDriver => new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
    }
}
