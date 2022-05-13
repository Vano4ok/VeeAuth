using VeeMessenger.Domain.Models.AuthenticationModels;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class PasswordValidationService : IPasswordValidationService
    {
        private readonly IAuthenticationErrorDescriberService errorDescriberService;

        public PasswordValidationService(IAuthenticationErrorDescriberService errorDescriberService)
        {
            this.errorDescriberService = errorDescriberService;
        }

        public IEnumerable<AuthenticationError> IsValid(string password)
        {
            List<AuthenticationError> errors = new List<AuthenticationError>();

            if (string.IsNullOrWhiteSpace(password) || password.Length <= 10)
            {
                errors.Add(errorDescriberService.PasswordTooShort(10));
            }
            if (password.All(IsLetterOrDigit))
            {
                errors.Add(errorDescriberService.PasswordRequiresNonAlphanumeric());
            }
            if (!password.Any(IsDigit))
            {
                errors.Add(errorDescriberService.PasswordRequiresDigit());
            }
            if (!password.Any(IsLower))
            {
                errors.Add(errorDescriberService.PasswordRequiresLower());
            }
            if (!password.Any(IsUpper))
            {
                errors.Add(errorDescriberService.PasswordRequiresUpper());
            }

            return errors;
        }

        private bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        private bool IsLower(char c)
        {
            return c >= 'a' && c <= 'z';
        }

        private bool IsUpper(char c)
        {
            return c >= 'A' && c <= 'Z';
        }

        private bool IsLetterOrDigit(char c)
        {
            return IsUpper(c) || IsLower(c) || IsDigit(c);
        }
    }
}
