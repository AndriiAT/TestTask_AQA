using OpenQA.Selenium;
using TestTask_AQA.Utils;

namespace TestTask_AQA.GooglePages
{
    public class GoogleResultsPage
    {

        private IReadOnlyCollection<IWebElement> _results =>
            Browser.Driver.FindElements(By.CssSelector("div#search h3"));



        public GoogleResultsPage() { }

        public bool ResultsExist()
        {
            return _results.Count > 0;
        }

        public bool FirstResultContains(string text)
        {
            var firstResult = _results.FirstOrDefault();
            return firstResult != null && firstResult.Text.Contains(text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
