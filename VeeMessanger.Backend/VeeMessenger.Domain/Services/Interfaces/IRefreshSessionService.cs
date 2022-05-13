using VeeMessenger.Data.Entities;
using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IRefreshSessionService
    {
        public Task<RefreshSession> CreateRefreshSessionAsync(Guid userId, string fingerPrint);

        public Task<AuthenticationErrorWithRefreshSession> UpdateRefreshSessionAsync(Guid refreshSessionId, string fingerPrint);

        public Task<IEnumerable<AuthenticationError>> DeleteRefreshSessionAsync(Guid refreshSessionId);
    }
}
