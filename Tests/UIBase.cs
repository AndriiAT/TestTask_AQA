using TestTask_AQA.Data;
using TestTask_AQA.Data.Constants;
using TestTask_AQA.Utils;

namespace TestTask_AQA.Tests
{
    public class UIBase : BaseTest
    {
        protected static void SetUpDriver()
        {
            switch (GlobalConfigs.Browser)
            {
                case Browsers.Chrome:
                    new Chrome();
                    break;
                case Browsers.Firefox:
                    new Firefox();
                    break;
                case Browsers.Edge:
                    new Edge();
                    break;
                default:
                    throw new Exception("Unsupported browser: " + GlobalConfigs.Browser);
            }
        }

        public override void StandardOneTimeSetUp()
        {
            GlobalConfigs.ReadConfigs();
            SetUpDriver();
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
