using OpenQA.Selenium;
using TestTask_AQA.Data;
using TestTask_AQA.Utils;

namespace TestTask_AQA.GooglePages
{
    public class GoogleHomePage
    {
        private IWebElement _searchBox =>
            Browser.Driver.FindElement(By.Name("q"));

        private IWebElement _searchBtn =>
            Browser.Driver.FindElement(By.XPath("//input[contains(@value, 'Google')]"));

        private IWebElement _signIn =>
            Browser.Driver.FindElement(By.XPath("//span[text()='Sign in']"));


        public GoogleHomePage() { }

        public void GoTo()
        {
            Browser.Driver.Navigate().GoToUrl(GlobalConfigs.BaseUrl);
        }

        public bool IsSearchBoxVisible()
        {
            return _searchBox.Displayed;
        }

        public void EnterSearchText(string searchText)
        {
            _searchBox.SendKeys(searchText);
        }

        public void CheckCapcha()
        {
            Browser.Driver.SwitchTo().Frame(0);
            new CheckPage().CheckCapcha();
            Browser.Driver.SwitchTo().DefaultContent();
        }

        public void SubmitSearch()
        {
            _searchBox.SendKeys(Keys.Enter);
        }
    }
}
