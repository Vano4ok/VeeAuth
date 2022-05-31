using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IUserNameValidationService
    {
        public IEnumerable<Error> IsValid(string userName);
    }
}
