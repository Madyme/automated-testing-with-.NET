using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;
using NUnit.Framework;
using MailKit.Security;
using Org.BouncyCastle.Crypto.Macs;

namespace Tests
{
	public class VerifyEmailTest
	{
		[Test]
		public void VerifyEmail()
		{
			using (var client = new ImapClient())
			{
				client.Connect("outlook.office365.com", 143, SecureSocketOptions.Auto);
				client.Authenticate("test010303@hotmail.com", "Test1***1");
				client.Inbox.Open(FolderAccess.ReadOnly);

				// search for new message
				var uids = client.Inbox.Search(SearchQuery.New);
				var inbox = client.Inbox;
				inbox.Open(FolderAccess.ReadOnly);
				var lastEmail = inbox.GetMessage(inbox.Count - 1);
				Console.WriteLine(lastEmail.MessageId);

				Console.WriteLine("You have {0} new message(s).", uids.Count); // count new unread message
				
				string actualEmailFromAddr = lastEmail.From.ToString();
				string expectedEmailFromAddr = "\"test1 testing1\" <testing1.test.test@gmail.com>";

				string actualEmailSubject = lastEmail.Subject.ToString();
				string expectedEmailSubject = "Test Subject";

				string actualEmailBody = lastEmail.TextBody.ToString();
				string expectedEmailBody = "This is a test content body from test account.";



				// verify sender's email
				Assert.AreEqual(expectedEmailFromAddr, actualEmailFromAddr, $"{expectedEmailFromAddr} is not equal to {actualEmailFromAddr}");

				// verify email subject
				Assert.AreEqual(expectedEmailSubject, actualEmailSubject, $"{actualEmailSubject} is not equal to {expectedEmailSubject}");

				// verify email body
				Assert.AreEqual(expectedEmailBody, actualEmailBody, $"{expectedEmailBody} is not equals to {actualEmailBody}");
				client.Disconnect(true);
			}
		}
	}
}
