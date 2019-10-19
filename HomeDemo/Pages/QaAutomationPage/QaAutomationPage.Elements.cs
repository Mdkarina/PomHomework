using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTestsPOM.Pages
{
    public partial class QaAutomationPage : BasePage
    {
        public QaAutomationPage(IWebDriver driver) : base(driver)
        {
            Navigate("http://www.softuni.bg");
        }

        private IWebElement NavigateBarEducationLink => Driver.FindElement(By.XPath("//*[contains(text(), 'Обучения')]"));

        private IWebElement QaCourseMenuItem => Driver.FindElement(By.XPath("//*[contains(text(), 'QA Automation - септември 2019')]"));

        private List<string> TextFieldsOfAllH1Elements => Driver.FindElements(By.TagName("h1")).Select(x => x.Text).ToList();
    }
}
