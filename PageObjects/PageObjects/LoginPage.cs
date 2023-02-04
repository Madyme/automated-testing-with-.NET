using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PageObjects
{
	public class LoginPage : BasePage
	{
		
		public LoginPage(IWebDriver webDriver) : base(webDriver)
		{
		}
	
		private IWebElement emailField => driver.FindElement(By.XPath("//input[@type='email']"));
		private IWebElement nextBtn => driver.FindElement(By.XPath("//*[@id='identifierNext']//button"));
		private IWebElement pswdField => driver.FindElement(By.XPath("//input[@type='password']"));
		private IWebElement loginBtn => driver.FindElement(By.XPath("//*[@id='passwordNext']/div/button"));
		private IWebElement errorMsg => driver.FindElement(By.XPath("//*[text()[contains(.,'Couldn’t find your Google Account')]]"));
		private IWebElement emptyEmailMsg => driver.FindElement(By.XPath("//*[text()[contains(.,'Enter an email or phone number')]]"));
		private IWebElement emptyPswdMsg => driver.FindElement(By.XPath("//*[text()[contains(.,'Enter a password')]]"));


		public void SendTextToEmail(string text) => emailField.SendKeys(text);
		public void ClickNextBtn() => nextBtn.Click();
		public void SendTextToPswdField(string text) => pswdField.SendKeys(text);
		public void ClickLoginBtn() => loginBtn.Click();
		public string GetErrorMsg() => errorMsg.Text;
		public string GetEmptyEmailMsg() => emptyEmailMsg.Text;
		public string GetEmptyPswdMsg() => emptyPswdMsg.Text;

		public InboxPage NavigateToInboxPage()
		{
			emailField.SendKeys("testing1.test.test@gmail.com");
			Thread.Sleep(2000);
			nextBtn.Click();
			Thread.Sleep(4000);
			pswdField.SendKeys("Test1***1");
			Thread.Sleep(2000);
			loginBtn.Click();
			Thread.Sleep(10000);
			return new InboxPage(driver);
		}
	}
}
