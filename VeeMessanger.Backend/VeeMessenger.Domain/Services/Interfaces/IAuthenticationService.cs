using VeeMessenger.Data.Entities;
using VeeMessenger.Domain.Dto;
using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IAuthenticationService
    {
        public Task<Result> CreateUserAsync(User user, string password);

        public Task<Result<TokensDto>> ConfrimEmailAsync(string email, string code, string fingerPrint);

        public Task<Result<TokensDto>> LoginAsync(string userName, string password, string fingerPrint);

        public Task<Result> LogoutAsync(Guid refreshSessionId);

        public Task<Result<TokensDto>> RefreshSessionAsync(Guid refreshSessionId, string fingerPrint);
    }
}
