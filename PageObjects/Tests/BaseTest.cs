using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
	public class BaseTest
	{
		protected IWebDriver driver;
		protected WebDriverWait wait; 


		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://gmail.com");
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
		}

		[TearDown]
		public void TearDown()
		{
			//driver.Close();
		}
	}
}