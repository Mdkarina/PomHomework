using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestsPOM.Pages.AutomationPracticeRegistrationPage;
using System.IO;
using System.Reflection;

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
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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
