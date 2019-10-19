using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestsPOM.Pages;
using System.IO;
using System.Reflection;

namespace SeleniumTestsPOM
{
    [TestFixture]
    class QaAutomationTest
    {
        private IWebDriver _driver;
        private QaAutomationPage _qaAutomationPage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _qaAutomationPage = new QaAutomationPage(_driver);
        }

        [Test]
        public void SoftUniQaAutomationTitleCheck()
        {
            _qaAutomationPage.NavigateToQaAutomationPage();
            _qaAutomationPage.AssertTitle("QA Automation - септември 2019");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
