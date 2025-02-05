using TestTask_AQA.Data;
using TestTask_AQA.Data.Constants;
using TestTask_AQA.Utils;

namespace TestTask_AQA.Tests
{
    public class UIBase : BaseTest
    {
        protected static void SetUpDriver(bool headless)
        {
            switch (GlobalConfigs.Browser)
            {
                case Browsers.Chrome:
                    new Chrome(headless);
                    break;
                case Browsers.Firefox:
                    new Firefox(headless);
                    break;
                case Browsers.Edge:
                    new Edge(headless);
                    break;
                default:
                    throw new Exception("Unsupported browser: " + GlobalConfigs.Browser);
            }
        }

        public override void StandardOneTimeSetUp()
        {
            GlobalConfigs.ReadConfigs();
            bool headless = Environment.GetEnvironmentVariable("HEADLESS") == "true";
            SetUpDriver(headless);
        }

        public override void StandardOneTimeTearDown()
        {
            if (Browser.Driver != null)
            {
                Browser.Driver.Quit();
                Browser.Driver.Dispose();
                Browser.Driver = null;
            }
        }
    }
}
