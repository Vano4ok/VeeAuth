using VeeMessenger.Domain.Models.AuthenticationModels;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class AuthenticationErrorDescriberService : IAuthenticationErrorDescriberService
    {
        public Error DuplicateUserName(string userName)
        {
            return new Error
            {
                Code = nameof(DuplicateUserName),
                Description = $"Username '{userName}' is already taken."
            };
        }

        public Error HasIllegalCharacters(string userName)
        {
            return new Error
            {
                Code = nameof(HasIllegalCharacters),
                Description = $"Username '{userName}' can contain only a-z, numbers (0-9) and symbols '.', '_'."
            };
        }

        public Error UsernameDoesNotExist(string userName)
        {
            return new Error
            {
                Code = nameof(UsernameDoesNotExist),
                Description = $"Username '{userName}' does not exist."
            };
        }

        public Error DuplicateEmail(string email)
        {
            return new Error
            {
                Code = nameof(DuplicateEmail),
                Description = $"Email '{email}' is already taken."
            };
        }

        public Error UserWithSuchEmailDoesntExist(string email)
        {
            return new Error
            {
                Code = nameof(UserWithSuchEmailDoesntExist),
                Description = $"User with email '{email}' doesn't exist."
            };
        }

        public Error UserIsAlreadyConfirmed(string userName)
        {
            return new Error
            {
                Code = nameof(UserIsAlreadyConfirmed),
                Description = $"User '{userName}' is already confirmed."
            };
        }

        public Error CodeIsinvalid(string code)
        {
            return new Error
            {
                Code = nameof(CodeIsinvalid),
                Description = $"Code '{code}' is invalid."
            };
        }

        public Error RegistrationFailed()
        {
            return new Error
            {
                Code = nameof(CodeIsinvalid),
                Description = $"Registration failed."
            };
        }

        public Error PasswordMismatch()
        {
            return new Error
            {
                Code = nameof(PasswordMismatch),
                Description = "Incorrect password."
            };
        }

        public Error PasswordTooShort(int RequiredLength)
        {
            return new Error
            {
                Code = nameof(PasswordTooShort),
                Description = $"Password must be at least {RequiredLength} characters."
            };
        }

        public Error PasswordRequiresNonAlphanumeric()
        {
            return new Error
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "Password must have at least one non alphanumeric character."
            };
        }

        public Error PasswordRequiresUpper()
        {
            return new Error
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "Password must have at least one uppercase ('A'-'Z')."
            };
        }

        public Error PasswordRequiresLower()
        {
            return new Error
            {
                Code = nameof(PasswordRequiresLower),
                Description = "Password must have at least one lowercase ('a'-'z')."
            };
        }

        public Error PasswordRequiresDigit()
        {
            return new Error
            {
                Code = nameof(PasswordRequiresDigit),
                Description = "Password must have at least one digit ('0'-'9')."
            };
        }

        public Error PasswordIsInvalid()
        {
            return new Error
            {
                Code = nameof(PasswordIsInvalid),
                Description = "Password is invalid."
            };
        }

        public Error EmailIsNotConfirmed(string email)
        {
            return new Error
            {
                Code = nameof(EmailIsNotConfirmed),
                Description = $"User with email {email} is not confirmed."
            };
        }

        public Error UserIsBlockedForLogin(DateTime dateTime)
        {
            return new Error
            {
                Code = nameof(UserIsBlockedForLogin),
                Description = $"User is blocked for login until {dateTime.ToString("g")}."
            };
        }

        public Error RefreshSessionIsNull()
        {
            return new Error
            {
                Code = nameof(RefreshSessionIsNull),
                Description = $"Refresh session is null."
            };
        }

        public Error RefreshSessionExpired()
        {
            return new Error
            {
                Code = nameof(RefreshSessionExpired),
                Description = $"Refresh session expired."
            };
        }

        public Error FingerPrintIsExist()
        {
            return new Error
            {
                Code = nameof(FingerPrintIsExist),
                Description = $"You are already login."
            };
        }

        public Error InvalidFingerPrint()
        {
            return new Error
            {
                Code = nameof(InvalidFingerPrint),
                Description = $"FingerPrint is invalid."
            };
        }
    }
}
