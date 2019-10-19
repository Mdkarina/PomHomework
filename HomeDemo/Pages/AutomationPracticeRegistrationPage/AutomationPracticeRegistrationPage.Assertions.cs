using NUnit.Framework;

namespace SeleniumTestsPOM.Pages.AutomationPracticeRegistrationPage
{
    public partial class AutomationPracticeRegistrationPage
    {
        public void AssertPageTitle(string expectedPageTitle)
        {
            Assert.AreEqual(expectedPageTitle, CreaetAccountTitle.Text);
        }
    }
}
