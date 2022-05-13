using VeeMessenger.Data.Entities;

namespace VeeMessenger.Domain.Models.AuthenticationModels
{
    public class AuthenticationErrorWithRefreshSession
    {
        public AuthenticationError? AuthenticationError { get; set; }

        public RefreshSession? RefreshSession { get; set; }
    }
}
