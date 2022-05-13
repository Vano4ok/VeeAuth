using VeeMessenger.Data.Entities;
using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IAuthenticationService
    {
        public Task<AuthenticationResult> CreateUserAsync(User user, string password);

        public Task<AuthenticationResultWithTokens> ConfrimEmailAsync(string email, string code, string fingerPrint);

        public Task<AuthenticationResultWithTokens> LoginAsync(string userName, string password, string fingerPrint);

        public Task<AuthenticationResult> LogoutAsync(Guid refreshSessionId);

        public Task<AuthenticationResultWithTokens> RefreshSessionAsync(Guid refreshSessionId, string fingerPrint);
    }
}
