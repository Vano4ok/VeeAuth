using VeeMessenger.Data.Entities;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IAccessTokenService
    {
        public Task<string> GetAccessToken(User user);
    }
}
