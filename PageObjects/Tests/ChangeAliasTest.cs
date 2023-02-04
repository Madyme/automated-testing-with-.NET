using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
	public class ChangeAliasTest : BaseTest
	{
		
		[Test]
	
		public void ChangeAlias()
		{
			LoginPage loginPage = new LoginPage(driver);
			var settingsPage = loginPage.NavigateToInboxPage()
			.NavigateToSettingsPage();
			Thread.Sleep(2000);
			settingsPage.ClickAccountBtn();
			Thread.Sleep(8000);

			string originalWindow = driver.CurrentWindowHandle;
			Assert.AreEqual(driver.WindowHandles.Count, 1);
			driver.FindElement(By.XPath("//span[contains(@class, 'sA') and text() = 'изменить']")).Click();
			wait.Until(wd => wd.WindowHandles.Count == 2);

			foreach (string window in driver.WindowHandles)
			{
				if (originalWindow != window)
				{
					driver.SwitchTo().Window(window);
					break;
				}
			}

			driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Testov Test");
			Thread.Sleep(2000);
			driver.FindElement(By.XPath("//input[@id='bttn_sub']")).Click();

			Thread.Sleep(2000);

		}
	}
}
