using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IPasswordValidationService
    {
        public IEnumerable<AuthenticationError> IsValid(string password);
    }
}
