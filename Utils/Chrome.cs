using OpenQA.Selenium.Chrome;

namespace TestTask_AQA.Utils
{
    public class Chrome : Browser
    {
        public Chrome()
        {
            Initialize();
        }

        protected override void Initialize(bool headless = false)
        {
            var options = GetOptions(headless);

            Driver = new ChromeDriver(options);
            Maximize();
        }

        private ChromeOptions GetOptions(bool headless)
        {
            ChromeOptions options = new ();
            if (headless)
                options.AddArgument("--headless");
            //can be added more options
            options.AddArgument("--disable-extensions");
            options.AddArgument("--whitelisted-ips=''");
            return options;
        }

        public override void Maximize()
        {
            Driver.Manage().Window.Maximize();
        }

        public override void Refresh()
        {
            Driver.Navigate().Refresh();
        }
    }
}