using VeeMessenger.Domain.Models.AuthenticationModels;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class AuthenticationErrorDescriberService : IAuthenticationErrorDescriberService
    {
        public AuthenticationError DuplicateUserName(string userName)
        {
            return new AuthenticationError
            {
                Code = nameof(DuplicateUserName),
                Description = $"Username '{userName}' is already taken."
            };
        }

        public AuthenticationError HasIllegalCharacters(string userName)
        {
            return new AuthenticationError
            {
                Code = nameof(HasIllegalCharacters),
                Description = $"Username '{userName}' can contain only a-z, numbers (0-9) and symbols '.', '_'."
            };
        }

        public AuthenticationError UsernameDoesNotExist(string userName)
        {
            return new AuthenticationError
            {
                Code = nameof(UsernameDoesNotExist),
                Description = $"Username '{userName}' does not exist."
            };
        }

        public AuthenticationError DuplicateEmail(string email)
        {
            return new AuthenticationError
            {
                Code = nameof(DuplicateEmail),
                Description = $"Email '{email}' is already taken."
            };
        }

        public AuthenticationError UserWithSuchEmailDoesntExist(string email)
        {
            return new AuthenticationError
            {
                Code = nameof(UserWithSuchEmailDoesntExist),
                Description = $"User with email '{email}' doesn't exist."
            };
        }

        public AuthenticationError UserIsAlreadyConfirmed(string userName)
        {
            return new AuthenticationError
            {
                Code = nameof(UserIsAlreadyConfirmed),
                Description = $"User '{userName}' is already confirmed."
            };
        }

        public AuthenticationError CodeIsinvalid(string code)
        {
            return new AuthenticationError
            {
                Code = nameof(CodeIsinvalid),
                Description = $"Code '{code}' is invalid."
            };
        }

        public AuthenticationError RegistrationFailed()
        {
            return new AuthenticationError
            {
                Code = nameof(CodeIsinvalid),
                Description = $"Registration failed."
            };
        }

        public AuthenticationError PasswordMismatch()
        {
            return new AuthenticationError
            {
                Code = nameof(PasswordMismatch),
                Description = "Incorrect password."
            };
        }

        public AuthenticationError PasswordTooShort(int RequiredLength)
        {
            return new AuthenticationError
            {
                Code = nameof(PasswordTooShort),
                Description = $"Password must be at least {RequiredLength} characters."
            };
        }

        public AuthenticationError PasswordRequiresNonAlphanumeric()
        {
            return new AuthenticationError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "Password must have at least one non alphanumeric character."
            };
        }

        public AuthenticationError PasswordRequiresUpper()
        {
            return new AuthenticationError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "Password must have at least one uppercase ('A'-'Z')."
            };
        }

        public AuthenticationError PasswordRequiresLower()
        {
            return new AuthenticationError
            {
                Code = nameof(PasswordRequiresLower),
                Description = "Password must have at least one lowercase ('a'-'z')."
            };
        }

        public AuthenticationError PasswordRequiresDigit()
        {
            return new AuthenticationError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = "Password must have at least one digit ('0'-'9')."
            };
        }

        public AuthenticationError PasswordIsInvalid()
        {
            return new AuthenticationError
            {
                Code = nameof(PasswordIsInvalid),
                Description = "Password is invalid."
            };
        }

        public AuthenticationError EmailIsNotConfirmed(string email)
        {
            return new AuthenticationError
            {
                Code = nameof(EmailIsNotConfirmed),
                Description = $"User with email {email} is not confirmed."
            };
        }

        public AuthenticationError UserIsBlockedForLogin(DateTime dateTime)
        {
            return new AuthenticationError
            {
                Code = nameof(UserIsBlockedForLogin),
                Description = $"User is blocked for login until {dateTime.ToString("g")}."
            };
        }

        public AuthenticationError RefreshSessionIsNull()
        {
            return new AuthenticationError
            {
                Code = nameof(RefreshSessionIsNull),
                Description = $"Refresh session is null."
            };
        }

        public AuthenticationError RefreshSessionExpired()
        {
            return new AuthenticationError
            {
                Code = nameof(RefreshSessionExpired),
                Description = $"Refresh session expired."
            };
        }

        public AuthenticationError InvalidFingerPrint()
        {
            return new AuthenticationError
            {
                Code = nameof(InvalidFingerPrint),
                Description = $"FingerPrint is invalid."
            };
        }
    }
}
