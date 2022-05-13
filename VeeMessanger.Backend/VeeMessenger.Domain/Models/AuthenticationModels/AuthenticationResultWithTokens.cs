using VeeMessenger.Data.Entities;

namespace VeeMessenger.Domain.Models.AuthenticationModels
{
    public class AuthenticationResultWithTokens
    {
        public AuthenticationResult AuthenticationResult { get; set; } = new AuthenticationResult();

        public string AccessToken { get; set; } = string.Empty;

        public RefreshSession RefreshSession { get; set; } = new RefreshSession();
    }
}
