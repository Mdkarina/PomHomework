using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestsPOM.Pages;
using SeleniumTestsPOM.Tests;

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
            _driver = GlobalSeleniumSettings.DefaultDriver;
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
