using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumTestsPOM.Pages.RegistrationNegativePage.LoginPage;
using SeleniumTestsPOM.Pages.RegistrationPage;
using System.IO;
using System.Reflection;

namespace SeleniumTestsPOM
{
    [TestFixture]
    public class RegistrationNegativeTests
    {
        private ChromeDriver _driver;
        private RegistrationUser _user;
        private RegistrationPage _registartionPage;
        private Account _account;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _registartionPage = new RegistrationPage(_driver);
            _user = UserFactory.CreateValidUser();

            var _loginPage = new LoginPage(_driver);
            _account = new Account(_loginPage, _registartionPage);
        }

        [Test]
        public void CheckingFirstNameIsRequired()
        {
            _user.FirstName = "";
            _account.Create(_user);

            _registartionPage.AssertErrorMessage("firstname is required.");
        }

        [Test]
        public void CheckingLastNameIsRequired()
        {
            _user.LastName = "";
            _account.Create(_user);

            _registartionPage.AssertErrorMessage("lastname is required.");
        }

        [Test]
        public void CheckingPhoneNumberIsRequired()
        {
            _user.MobilePhone = "";
            _account.Create(_user);

            _registartionPage.AssertErrorMessage("You must register at least one phone number.");
        }

        [Test]
        public void CheckingPasswordIsRequired()
        {
            _user.Password = "";
            _account.Create(_user);

            _registartionPage.AssertErrorMessage("passwd is required.");
        }

        [Test]
        public void CheckingAddressIsRequired()
        {
            _user.Address = "";
            _account.Create(_user);

            _registartionPage.AssertErrorMessage("address1 is required.");
        }

        [Test]
        public void CheckingCityIsRequired()
        {
            _user.City = "";
            _account.Create(_user);

            _registartionPage.AssertErrorMessage("city is required.");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
