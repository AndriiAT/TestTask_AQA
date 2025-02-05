using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestTask_AQA.Utils;

namespace TestTask_AQA.GooglePages
{
    public class CheckPage
    {
        private IWebElement _capchaCB =>
            Browser.Driver.FindElement(By.XPath("//*[@id='recaptcha-anchor']"));


        public CheckPage() { }

        public void CheckCapcha()
        {
            WaitForPageToLoad();
            _capchaCB.Click();
        }

        private void WaitForPageToLoad()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => _capchaCB.Displayed);
        }
    }
}
