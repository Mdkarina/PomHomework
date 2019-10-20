using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTestsPOM.Tests
{
    [TestFixture]
    class SeleniumGridTest
    {
        IWebDriver _driver;
        string _baseUrl;

        [SetUp]
        public void SetUp()
        {
            _baseUrl = "https://www.saucedemo.com/";
            _driver = GlobalSeleniumSettings.DefaultDriver;
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
