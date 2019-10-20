using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestsPOM.Pages.GooglePage;
using SeleniumTestsPOM.Tests;

namespace SeleniumTestsPOM
{
    [TestFixture]
    class GoogleTest
    {
        private IWebDriver _driver;
        private GooglePage _googlePage;

        [SetUp]
        public void SetUp()
        {
            _driver = GlobalSeleniumSettings.DefaultDriver;
            _googlePage = new GooglePage(_driver);
        }

        [Test]
        public void GoogleSearch()
        {
            _googlePage.Search("Selenium");
            _googlePage.NavigatToFirstResult();

            _googlePage.AssertPageTitle("Selenium - Web Browser Automation");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
