using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
	public class BasePage
	{
		protected static IWebDriver driver;
		//protected WebDriverWait wait;

		public BasePage(IWebDriver webDriver)
		{
			driver = webDriver;
			//wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
		}

	}
}