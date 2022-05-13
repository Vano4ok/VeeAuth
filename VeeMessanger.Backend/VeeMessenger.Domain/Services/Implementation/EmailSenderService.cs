using System.Net;
using System.Net.Mail;
using VeeMessenger.Domain.Models.EmailModels;
using VeeMessenger.Domain.Models.SettingsModels;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly EmailSettings emailSettings;

        public EmailSenderService(EmailSettings emailSettings)
        {
            this.emailSettings = emailSettings;
        }

        public async Task SendEmailAsync(EmailRequest emailRequest)
        {
            MailAddress from = new MailAddress(emailSettings.Username, emailSettings.From);

            MailAddress to = new MailAddress(emailRequest.ToEmail);

            MailMessage message = new MailMessage(from, to);

            message.Subject = emailRequest.Subject;

            message.Body = emailRequest.Body;

            message.IsBodyHtml = true;

            using (SmtpClient client = new SmtpClient(emailSettings.SmtpServer, emailSettings.Port))
            {
                client.Credentials = new NetworkCredential(emailSettings.Username, emailSettings.Password);
                client.EnableSsl = true;

                await client.SendMailAsync(message);
            }
        }
    }
}
