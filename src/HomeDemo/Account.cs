using SeleniumTestsPOM.Pages.RegistrationNegativePage.LoginPage;
using SeleniumTestsPOM.Pages.RegistrationPage;

namespace SeleniumTestsPOM
{
    public class Account
    {
        readonly LoginPage _loginPage;
        readonly RegistrationPage _registrationPage;

        public Account(LoginPage loginPage, RegistrationPage registrationPage)
        {
            _loginPage = loginPage;
            _registrationPage = registrationPage;
        }

        public void Create(RegistrationUser user)
        {
            _loginPage.CreateNewAccountAndNavigateToRegisterPage(user.Email);
            _registrationPage.FillNessesaryAccountInformation(user);
            _registrationPage.Register();
        }
    }
}
