using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Utils
{
	/// <summary>
	/// Sending mail using Gmail Smtp
	/// </summary>
	public class SmtpHandling
	{
		readonly SmtpConfigurations _smtpConfigurations;
		public SmtpHandling(IOptions<SmtpConfigurations> smtpConfiguration)
		{
			_smtpConfigurations = smtpConfiguration.Value;
		}
		public void SendEmail(string toEmail, string subject, string textBody, string htmlBody)
		{
			using (var client = new SmtpClient())
			{
				client.Connect(_smtpConfigurations.SmtpAddress);
				client.Authenticate(_smtpConfigurations.SmtpUserName, _smtpConfigurations.SmtpPassWord);
				var bodyBuilder = new BodyBuilder
				{
					HtmlBody = htmlBody,
					TextBody = textBody
				};
				var message = new MimeMessage
				{
					Body = bodyBuilder.ToMessageBody()
				};
				message.From.Add(new MailboxAddress(_smtpConfigurations.ContactFromName, _smtpConfigurations.ContatcFromAddress));
				message.To.Add(new MailboxAddress("", toEmail));
				message.Subject = subject;
				client.Send(message);
				client.Disconnect(true);
			}
		}
	}
}
