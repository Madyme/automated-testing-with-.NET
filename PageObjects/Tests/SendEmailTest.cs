using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using NUnit.Framework;
using PageObjects;

namespace Tests
{
	public class SendEmailTest : BaseTest
	{
		//[Test]
		//public void SendEmail()
		//{
		//	try
		//	{
		//		// sender's email
		//		MailMessage email = new MailMessage();
		//		string fromEmail = "madina010303@outlook.com";
		//		string fromPassword = "Madina1**1";

		//		string toEmail = "testing11905@outlook.com";
		//		string subject = "Test Subject";
		//		string contentBody = "<h3> Test Content Body from selenium </h3>";
		//		email.From = new MailAddress(fromEmail);
		//		email.To.Add(toEmail);
		//		email.Subject = subject;
		//		email.Body = contentBody;
		//		email.IsBodyHtml = true;

		//		SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
		//		smtp.UseDefaultCredentials = true;
		//		smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
		//		smtp.EnableSsl = true;
		//		smtp.Send(email);


		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine(ex.Message);
		//	}e
		//  }
		[Test]
		public void SendEmail()
		{
			LoginPage loginPage = new LoginPage(driver);
			var inboxPage = loginPage.NavigateToInboxPage();
			inboxPage.ClickWriteEmailBtn();
			Thread.Sleep(4000);
			inboxPage.InputToReceiverEmailAddr("test010303@hotmail.com");
			inboxPage.InputToEmailSubject("Test Subject");
			inboxPage.InputToEmailContentBody("This is a test content body from test account.");
			Thread.Sleep(4500);

			inboxPage.ClickSendEmailBtn();
			Thread.Sleep(3000);
		}
	}
}

// testing11905@outlook.com