namespace SeleniumTestsPOM.Pages.AutomationPracticeRegistrationPage
{
    public partial class AutomationPracticeRegistrationPage
    {
        public void NavigateToRegistartionPage()
        {
            SignInLink.Click();
            CreateEmailInput.SendKeys("test@yahoo.asd");
            CreateAccountButton.Click();
        }
    }
}
