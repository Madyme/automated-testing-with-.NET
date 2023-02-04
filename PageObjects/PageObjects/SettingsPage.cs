using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
	public class SettingsPage : BasePage
	{
		public SettingsPage(IWebDriver webDriver) : base(webDriver) { }
		private IWebElement accountBtn = driver.FindElement(By.XPath("//a[@href='https://mail.google.com/mail/u/0/#settings/accounts']"));
		

		public void ClickAccountBtn() => accountBtn.Click();

	}

	
}
