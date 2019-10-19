namespace SeleniumTestsPOM.Pages.RegistrationNegativePage.LoginPage
{
    public partial class LoginPage
    {
        public void CreateNewAccountAndNavigateToRegisterPage(string email)
        {
            Navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            CreatwEmailInput.SendKeys(email);
            CreaetAccountButton.Click();
        }
    }
}
