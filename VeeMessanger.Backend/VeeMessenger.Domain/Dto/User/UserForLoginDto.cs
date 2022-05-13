namespace VeeMessenger.Domain.Dto.User
{
    public class UserForLoginDto
    {
        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string FingerPrint { get; set; } = string.Empty;
    }
}
