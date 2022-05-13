using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IAuthenticationErrorDescriberService
    {
        public AuthenticationError PasswordMismatch();

        public AuthenticationError DuplicateUserName(string userName);

        public AuthenticationError HasIllegalCharacters(string userName);

        public AuthenticationError UsernameDoesNotExist(string userName);

        public AuthenticationError DuplicateEmail(string email);

        public AuthenticationError UserWithSuchEmailDoesntExist(string email);

        public AuthenticationError UserIsAlreadyConfirmed(string userName);

        public AuthenticationError CodeIsinvalid(string code);

        public AuthenticationError RegistrationFailed();

        public AuthenticationError PasswordTooShort(int RequiredLength);

        public AuthenticationError PasswordRequiresNonAlphanumeric();

        public AuthenticationError PasswordRequiresUpper();

        public AuthenticationError PasswordRequiresLower();

        public AuthenticationError PasswordRequiresDigit();

        public AuthenticationError PasswordIsInvalid();

        public AuthenticationError EmailIsNotConfirmed(string email);

        public AuthenticationError UserIsBlockedForLogin(DateTime dateTime);

        public AuthenticationError RefreshSessionIsNull();

        public AuthenticationError RefreshSessionExpired();

        public AuthenticationError InvalidFingerPrint();
    }
}
