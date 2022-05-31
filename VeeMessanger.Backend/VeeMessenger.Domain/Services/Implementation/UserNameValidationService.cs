using System.Text.RegularExpressions;
using VeeMessenger.Domain.Models.AuthenticationModels;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class UserNameValidationService : IUserNameValidationService
    {
        private readonly IAuthenticationErrorDescriberService errorDescriberService;

        public UserNameValidationService(IAuthenticationErrorDescriberService errorDescriberService)
        {
            this.errorDescriberService = errorDescriberService;
        }

        public IEnumerable<Error> IsValid(string userName)
        {
            List<Error> errors = new List<Error>();

            if (!Regex.IsMatch(userName, @"^[a-zA-Z0-9_.]+$"))
            {
                errors.Add(errorDescriberService.HasIllegalCharacters(userName));
            }

            return errors;
        }
    }
}
