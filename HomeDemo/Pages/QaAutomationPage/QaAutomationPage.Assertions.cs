using NUnit.Framework;

namespace SeleniumTestsPOM.Pages
{
    public partial class QaAutomationPage
    {
        public void AssertTitle(string expectedTitle)
        {
            Assert.Contains(expectedTitle, TextFieldsOfAllH1Elements);
        }
    }
}
