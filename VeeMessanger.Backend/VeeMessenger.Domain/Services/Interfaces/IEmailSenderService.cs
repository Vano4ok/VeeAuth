using VeeMessenger.Domain.Models.EmailModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IEmailSenderService
    {
        public Task SendEmailAsync(EmailRequest emailRequest);
    }
}
