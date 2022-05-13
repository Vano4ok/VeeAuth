using Microsoft.AspNetCore.Http;

namespace VeeMessenger.Domain.Models.EmailModels
{
    public class EmailRequest
    {
        public string ToEmail { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;

        public string Body { get; set; } = string.Empty;

        public List<IFormFile> Attachments { get; set; } = new List<IFormFile>();
    }
}
