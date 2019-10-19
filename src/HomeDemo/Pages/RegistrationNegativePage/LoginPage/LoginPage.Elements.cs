using OpenQA.Selenium;

namespace SeleniumTestsPOM.Pages.RegistrationNegativePage.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        { }

        private IWebElement CreatwEmailInput => Driver.FindElement(By.Id("email_create"));

        private IWebElement CreaetAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
    }
}
