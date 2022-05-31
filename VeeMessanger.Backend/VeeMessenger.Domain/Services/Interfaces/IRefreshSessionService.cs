using VeeMessenger.Data.Entities;
using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IRefreshSessionService
    {
        public Task<RefreshSession> CreateRefreshSessionAsync(Guid userId, string fingerPrint);

        public Task<Result<RefreshSession>> UpdateRefreshSessionAsync(Guid refreshSessionId, string fingerPrint);

        public Task<IEnumerable<Error>> DeleteRefreshSessionAsync(Guid refreshSessionId);
    }
}
