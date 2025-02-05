namespace TestTask_AQA.Utils
{
    public class Firefox : Browser
    {
        public Firefox(bool headless)
        {
            Initialize(headless);
        }

        protected override void Initialize(bool headless = false)
        {
            var options = GetOptions(headless);
            Driver = new OpenQA.Selenium.Firefox.FirefoxDriver(options);
            Maximize();
        }

        private OpenQA.Selenium.Firefox.FirefoxOptions GetOptions(bool headless)
        {
            OpenQA.Selenium.Firefox.FirefoxOptions options = new();
            if (headless)
                options.AddArgument("--headless");
            //can be added more options
            options.AddArgument("--disable-extensions");
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
