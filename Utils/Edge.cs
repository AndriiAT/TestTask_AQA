namespace TestTask_AQA.Utils
{
    public class Edge : Browser
    {
        public Edge(bool headless)
        {
            Initialize(headless);
        }
        protected override void Initialize(bool headless = false)
        {
            var options = GetOptions(headless);
            Driver = new OpenQA.Selenium.Edge.EdgeDriver(options);
            Maximize();
        }
        private OpenQA.Selenium.Edge.EdgeOptions GetOptions(bool headless)
        {
            OpenQA.Selenium.Edge.EdgeOptions options = new();
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
