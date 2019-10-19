using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestsPOM.Pages.GooglePage;
using System.IO;
using System.Reflection;

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
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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
