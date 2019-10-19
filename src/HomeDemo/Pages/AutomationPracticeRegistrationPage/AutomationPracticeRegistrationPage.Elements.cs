using OpenQA.Selenium;

namespace SeleniumTestsPOM.Pages.AutomationPracticeRegistrationPage
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public AutomationPracticeRegistrationPage(IWebDriver driver) : base(driver)
        {
            Navigate("http://automationpractice.com/index.php");
        }

        private IWebElement SignInLink => Driver.FindElement(By.XPath("//*[contains(text(), 'Sign in')]"));

        private IWebElement CreateEmailInput
        {
            get
            {
                return Wait.Until<IWebElement>((w) => w.FindElement(By.Id("email_create")));
            }
        }

        private IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

        private IWebElement CreaetAccountTitle
        {
            get
            {
                return Wait.Until<IWebElement>((w) => w.FindElement(By.XPath("//*[contains(text(), 'Create')]")));
            }
        }
    }
}
