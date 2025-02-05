using OpenQA.Selenium;

namespace TestTask_AQA.Utils
{
	/// <summary>
	/// Class Browser is Base class with shared functionality for all browser types
	/// </summary>
	public class Browser
	{
		/// <summary>
		/// The instance of a IWebDriver
		/// </summary>
		public static IWebDriver Driver { get; set; }

        /// <summary>
        /// The instance of a Browser and set headless mode if needed
        /// </summary>
        /// <param name="headless"></param>
        protected virtual void Initialize(bool headless = false) { }

        public virtual void Maximize()
		{
			Driver.Manage().Window.Maximize();
		}

		public virtual void Refresh()
		{
			Driver.Navigate().Refresh();
		}
	}
}