using OpenQA.Selenium;

namespace SeleniumTestsPOM.Pages.GooglePage
{
    public partial class GooglePage : BasePage
    {
        public GooglePage(IWebDriver driver) : base(driver)
        {
            Navigate("http://www.google.com");
        }

        private IWebElement SearchInput => Driver.FindElement(By.Name("q"));

        private IWebElement FirstSearchResult => Driver.FindElement(By.XPath("//h3/ancestor::a"));

        public string PageTitle => Driver.Title;
    }
}
