namespace VeeMessenger.Domain.Dto.User
{
    public class UserForConfirmDto
    {
        public string Email { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string FingerPrint { get; set; } = string.Empty;
    }
}
