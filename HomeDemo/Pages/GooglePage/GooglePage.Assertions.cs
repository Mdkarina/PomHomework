using NUnit.Framework;

namespace SeleniumTestsPOM.Pages.GooglePage
{
    public partial class GooglePage
    {
        public void AssertPageTitle(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, PageTitle);
        }
    }
}
