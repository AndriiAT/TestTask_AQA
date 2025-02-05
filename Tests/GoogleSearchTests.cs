using NUnit.Framework;
using TestTask_AQA.GooglePages;

namespace TestTask_AQA.Tests
{
    [TestFixture]
    public class GoogleSearchTests : UIBase
    {
        private GoogleHomePage _googleHomePage;
        private GoogleResultsPage _googleResultsPage;

        public override void ExtendedOneTimeSetUp()
        {
            _googleHomePage = new GoogleHomePage();
            _googleResultsPage = new GoogleResultsPage();
        }

        [Test]
        public void SearchForSeleniumCSharpTutorial_ShouldReturnResults()
        {
            _googleHomePage.GoTo();

            Assert.That(_googleHomePage.IsSearchBoxVisible(), Is.True);

            _googleHomePage.EnterSearchText("Selenium C# tutorial");
            _googleHomePage.SubmitSearch();

            //comment because of I got capcha
            _googleHomePage.CheckCapcha();
            Assert.That(_googleResultsPage.ResultsExist(), Is.True);
            Assert.That(_googleResultsPage.FirstResultContains("Selenium"), Is.True);
        }
    }
}
