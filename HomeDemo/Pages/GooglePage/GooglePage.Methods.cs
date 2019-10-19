using OpenQA.Selenium;

namespace SeleniumTestsPOM.Pages.GooglePage
{
    public partial class GooglePage
    {
        public void Search(string term)
        {
            SearchInput.SendKeys(term);
            SearchInput.SendKeys(Keys.Enter);
        }

        public void NavigatToFirstResult()
        {
            FirstSearchResult.Click();
        }
    }
}
