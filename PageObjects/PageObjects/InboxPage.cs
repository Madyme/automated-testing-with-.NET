using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
	public class InboxPage : BasePage
	{
		public InboxPage(IWebDriver webDriver) : base(webDriver) { }

		private IWebElement writeEmailBtn => driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div/div"));
		private IWebElement receiverEmailAddr => driver.FindElement(By.XPath("//div[@aria-label='Кому']//input"));
		private IWebElement emailSubject => driver.FindElement(By.XPath("//input[@name='subjectbox']"));
		private IWebElement emailContentBody => driver.FindElement(By.XPath("//div[@role='textbox']"));
		private IWebElement settingsBtn = driver.FindElement(By.XPath("//a[@class='FH']"));


		public void ClickWriteEmailBtn() => writeEmailBtn.Click();
		public void InputToReceiverEmailAddr(string text) => receiverEmailAddr.SendKeys(text);
		public void InputToEmailSubject(string text) => emailSubject.SendKeys(text);
		public void InputToEmailContentBody(string text) => emailContentBody.SendKeys(text);

		public void ClickSendEmailBtn() => emailContentBody.SendKeys(Keys.Control + Keys.Enter);

		public SettingsPage NavigateToSettingsPage()
		{
			Thread.Sleep(2000);
			settingsBtn.Click();
			Thread.Sleep(7000);
			driver.FindElement(By.XPath("//button[@aria-label='Все настройки']")).Click();
			Thread.Sleep(25000);
			return new SettingsPage(driver);
		}

	}
}
