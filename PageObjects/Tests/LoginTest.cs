using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System.Diagnostics.Metrics;

namespace Tests
{
	public class LoginTest : BaseTest
	{
		LoginPage login;
		[Test]
		public void PositiveLogin()
		{
			login = new LoginPage(driver);
			login.SendTextToEmail("testing1.test.test@gmail.com");
			Thread.Sleep(2000);
			login.ClickNextBtn();
			Thread.Sleep(4000);
			login.SendTextToPswdField("Test1***1");
			Thread.Sleep(2000);
			login.ClickLoginBtn();
			Thread.Sleep(10000);
			string expectedUrl = "https://mail.google.com/mail/u/0/#inbox";
			var actualUrl = driver.Url;
			Assert.AreEqual(expectedUrl, actualUrl, $"{expectedUrl} is not equal to {actualUrl}");
		}

		[Test]

		public void NegativeLoginWithInvalidEmail() {
			login = new LoginPage(driver);
			login.SendTextToEmail("tts@tt.com");
			Thread.Sleep(2000);
			login.ClickNextBtn();
			Thread.Sleep(4000);
			string expectedResult = "Couldn’t find your Google Account";
			string actualResult = login.GetErrorMsg();
			Assert.AreEqual(expectedResult, actualResult, $"{expectedResult} is not equal to {actualResult}");
		}

		[Test]

		public void NegativeLoginWithEmptyEmail() {
			login = new LoginPage(driver);
			Thread.Sleep(1000);
			login.ClickNextBtn();
			string actualMessage = login.GetEmptyEmailMsg();
			string expectedMessage = "Enter an email or phone number";
			Assert.AreEqual(expectedMessage, actualMessage, $"{expectedMessage} is not equal to {actualMessage}");
		}

		[Test]

		public void NegativeLoginWithEmptyPassword()
		{
			login = new LoginPage(driver);
			Thread.Sleep(1000);
			login.SendTextToEmail("testing1.test.test@gmail.com");
			Thread.Sleep(2000);
			login.ClickNextBtn();
			Thread.Sleep(4000);
			login.ClickLoginBtn();
			string actualMessage = login.GetEmptyPswdMsg();
			string expectedMessage = "Enter a password";
			Assert.AreEqual(expectedMessage, actualMessage, $"{expectedMessage} is not equal to {actualMessage}");
		}
	}
}
