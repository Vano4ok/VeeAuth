using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IPasswordValidationService
    {
        public IEnumerable<Error> IsValid(string password);
    }
}
