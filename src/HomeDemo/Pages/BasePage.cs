using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestsPOM
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }

        public IWebDriver Driver { get; private set; }
        public WebDriverWait Wait { get; private set; }

        protected void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
