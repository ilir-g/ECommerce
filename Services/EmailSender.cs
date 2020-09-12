using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class EmailSender : IEmailSender
    {
        // Our private configuration variables
        public string HostSmtp { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }
        public string FromEmail { get; set; }
        public string Password { get; set; }
       

        // Use our configuration to send the email by using SmtpClient
        public Task SendEmailAsync(string Toemail, string subject, string htmlMessage)
        {
            var client = new SmtpClient(HostSmtp, Port)
            {
                Credentials = new NetworkCredential(FromEmail, Password),
                EnableSsl = EnableSSL
            };
            return client.SendMailAsync(
                new MailMessage(FromEmail, Toemail, subject, htmlMessage) { IsBodyHtml = true }
            );
        }
    }
}


