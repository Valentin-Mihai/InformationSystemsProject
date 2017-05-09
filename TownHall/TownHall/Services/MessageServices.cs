using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

using System.Threading.Tasks;

namespace TownHall.Services
{
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            Execute(subject, message, email).Wait();
            return Task.FromResult(0);
        }

        public async Task Execute( string subject, string message, string email)
        {
            var fromAddress = new MailAddress("townhallproject2017@gmail.com", "TownHall Project");
            var toAddress = new MailAddress(email);
            const string fromPassword = "parolatownhallproject2017";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var emailmessage = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = message
            })
            {
                await smtp.SendMailAsync(emailmessage);
            }
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}