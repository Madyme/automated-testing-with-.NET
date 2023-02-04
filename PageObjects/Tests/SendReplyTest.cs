using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Tests
{
	public class SendReplyTest
	{
		public string Alias { get; set; } = "Test account";

		[Test]
		public void SendReply()
		{
			// sender's email
			MailMessage email = new MailMessage();
			string fromEmail = "test010303@hotmail.com";
			string fromPassword = "Test1***1";

			string toEmail = "testing1.test.test@gmail.com";
			string contentBody = $"<h3> {Alias} </h3>";
			email.Headers.Add("In-Reply-To", "CAFFjKPsGr95DiOUCa58ZRFvPvdyULBG8bkoy+ijX6QDGccOYVA@mail.gmail.com");
			email.Headers.Add("References", "CAFFjKPsGr95DiOUCa58ZRFvPvdyULBG8bkoy+ijX6QDGccOYVA@mail.gmail.com");
			email.From = new MailAddress(fromEmail);
			email.To.Add(toEmail);
			email.Subject = "Re:" + "Test Subject";
			email.Body = contentBody;
			email.IsBodyHtml = true;

			
			SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
			smtp.UseDefaultCredentials = false;
			smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
			smtp.EnableSsl = true;
			smtp.Send(email);
		}
	}
}
