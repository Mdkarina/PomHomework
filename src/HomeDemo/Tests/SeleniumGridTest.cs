using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumTestsPOM.Tests
{
    [TestFixture]
    class SeleniumGridTest
    {
        IWebDriver _driver;
        string _baseUrl, _nodeUrl;

        [SetUp]
        public void SetUp()
        {
            _baseUrl = "https://www.saucedemo.com/";
            _nodeUrl = "http://10.0.4.46:39406/wd/hub";

            ChromeOptions options = new ChromeOptions();
            options.PlatformName = "WINDOWS";
            options.BrowserVersion = "77.0";

            _driver = new RemoteWebDriver(new Uri(_nodeUrl), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(100);
        }

        [Test]
        public void Test()
        {
            _driver.Navigate().GoToUrl(_baseUrl);
            Assert.AreEqual("Swag Labs", _driver.Title);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
