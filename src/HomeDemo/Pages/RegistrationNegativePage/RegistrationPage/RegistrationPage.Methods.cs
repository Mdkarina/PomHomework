using OpenQA.Selenium;
using System;

namespace SeleniumTestsPOM.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {
        public bool TryClearFiledBeforeType(IWebElement element, string text)
        {
            try
            {
                element.Clear();
                element.SendKeys(text);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public void FillNessesaryAccountInformation(RegistrationUser user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            PostCode.SendKeys(user.PostCode);
            MobilePhone.SendKeys(user.MobilePhone);
            TryClearFiledBeforeType(Alias, user.Alias);
        }

        public void Register()
        {
            RegisterButton.Click();
        }
    }
}
