using VeeMessenger.Data.Entities;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IAccessTokenService
    {
        public string GetAccessToken(User user);
    }
}
