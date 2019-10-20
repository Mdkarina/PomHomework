using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestsPOM.Pages.AutomationPracticeRegistrationPage;
using SeleniumTestsPOM.Tests;

namespace SeleniumTestsPOM
{
    [TestFixture]
    class AutomationPracticeRegistrationTest
    {
        private IWebDriver _driver;
        private AutomationPracticeRegistrationPage _automationPracticeRegistrationPage;

        [SetUp]
        public void SetUp()
        {
            _driver = GlobalSeleniumSettings.DefaultDriver;
            _automationPracticeRegistrationPage = new AutomationPracticeRegistrationPage(_driver);
        }

        [Test]
        public void AutomationPracticeRegistration()
        {
            _automationPracticeRegistrationPage.NavigateToRegistartionPage();
            _automationPracticeRegistrationPage.AssertPageTitle("CREATE AN ACCOUNT");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

    }
}
