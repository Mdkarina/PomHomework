using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestsPOM.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement FirstName
        {
            get { return Wait.Until<IWebElement>((w) => w.FindElement(By.Id("customer_firstname"))); }
        }

        private IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        private IWebElement Password => Driver.FindElement(By.Id("passwd"));

        private IWebElement Address => Driver.FindElement(By.Id("address1"));

        private IWebElement City => Driver.FindElement(By.Id("city"));

        private SelectElement State
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(reminder);
            }
        }

        private IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        private IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        private IWebElement Alias => Driver.FindElement(By.Id("alias"));

        private IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));
    }
}
