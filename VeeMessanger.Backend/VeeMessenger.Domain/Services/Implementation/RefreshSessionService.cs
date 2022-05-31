using VeeMessenger.Data.Entities;
using VeeMessenger.Data.Infrastructure;
using VeeMessenger.Domain.Models.AuthenticationModels;
using VeeMessenger.Domain.Models.SettingsModels;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class RefreshSessionService : IRefreshSessionService
    {
        private readonly IRepository<RefreshSession> refreshSessionRepository;
        private readonly IAuthenticationErrorDescriberService errorDescriberService;
        private readonly JwtSettings jwtSettings;

        public RefreshSessionService(IRepository<RefreshSession> refreshSessionRepository, IAuthenticationErrorDescriberService errorDescriberService, JwtSettings jwtSettings)
        {
            this.refreshSessionRepository = refreshSessionRepository;
            this.errorDescriberService = errorDescriberService;
            this.jwtSettings = jwtSettings;
        }

        public async Task<RefreshSession> CreateRefreshSessionAsync(Guid userId, string fingerPrint)
        {
            RefreshSession refreshSession = new RefreshSession()
            {
                FingerPrint = fingerPrint,
                Expires = DateTime.Now.AddDays(jwtSettings.RefreshTokenExpirationMinutes),
                Created = DateTime.Now,
                UserId = userId
            };

            await refreshSessionRepository.AddAsync(refreshSession);

            await refreshSessionRepository.SaveChangesAsync();

            return refreshSession;
        }

        public async Task<Result<RefreshSession>> UpdateRefreshSessionAsync(Guid refreshSessionId, string fingerPrint)
        {
            Result<RefreshSession> result = new Result<RefreshSession>();

            var refreshSession = await refreshSessionRepository.GetByIdAsync(refreshSessionId);

            if (refreshSession is null)
            {
                result.AddErrors(errorDescriberService.RefreshSessionIsNull());

                return result;
            }

            refreshSessionRepository.Delete(refreshSession);

            await refreshSessionRepository.SaveChangesAsync();

            if (DateTime.Now > refreshSession.Expires)
            {
                result.AddErrors(errorDescriberService.RefreshSessionExpired());

                return result;
            }

            if (!fingerPrint.Equals(refreshSession.FingerPrint))
            {
                result.AddErrors(errorDescriberService.InvalidFingerPrint());
                return result;
            }

            result.Data = await CreateRefreshSessionAsync(refreshSession.UserId, fingerPrint);

            return result;
        }

        public async Task<IEnumerable<Error>> DeleteRefreshSessionAsync(Guid refreshSessionId)
        {
            List<Error> authenticationErrors = new List<Error>();

            var refreshSession = await refreshSessionRepository.GetByIdAsync(refreshSessionId);

            if (refreshSession is null)
            {
                authenticationErrors.Add(errorDescriberService.RefreshSessionIsNull());

                return authenticationErrors;
            }

            refreshSessionRepository.Delete(refreshSession);

            await refreshSessionRepository.SaveChangesAsync();

            return authenticationErrors;
        }
    }
}
