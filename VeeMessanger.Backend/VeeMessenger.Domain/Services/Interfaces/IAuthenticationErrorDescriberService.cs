using VeeMessenger.Domain.Models.AuthenticationModels;

namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IAuthenticationErrorDescriberService
    {
        public Error PasswordMismatch();

        public Error DuplicateUserName(string userName);

        public Error HasIllegalCharacters(string userName);

        public Error UsernameDoesNotExist(string userName);

        public Error DuplicateEmail(string email);

        public Error UserWithSuchEmailDoesntExist(string email);

        public Error UserIsAlreadyConfirmed(string userName);

        public Error CodeIsinvalid(string code);

        public Error RegistrationFailed();

        public Error PasswordTooShort(int RequiredLength);

        public Error PasswordRequiresNonAlphanumeric();

        public Error PasswordRequiresUpper();

        public Error PasswordRequiresLower();

        public Error PasswordRequiresDigit();

        public Error PasswordIsInvalid();

        public Error EmailIsNotConfirmed(string email);

        public Error UserIsBlockedForLogin(DateTime dateTime);

        public Error RefreshSessionIsNull();

        public Error RefreshSessionExpired();

        public Error FingerPrintIsExist();

        public Error InvalidFingerPrint();
    }
}
