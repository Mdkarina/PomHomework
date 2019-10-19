using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTestsPOM.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {
        public string HandelErrorMessages
        {
            get
            {
                string errorMessage = "";
                foreach (var element in Driver.FindElements(By.CssSelector(".alert.alert-danger li")))
                {
                    errorMessage = element.Text;
                }
                return errorMessage;
            }
        }

        public void AssertErrorMessage(string expected)
        {
            Assert.AreEqual(expected, HandelErrorMessages);
        }
    }
}
