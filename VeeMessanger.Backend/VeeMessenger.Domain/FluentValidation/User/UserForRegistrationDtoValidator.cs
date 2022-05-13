using FluentValidation;
using VeeMessenger.Data.Constants;
using VeeMessenger.Domain.Dto.User;

namespace VeeMessenger.Domain.FluentValidation.User
{
    public class UserForRegistrationDtoValidator : AbstractValidator<UserForRegistrationDto>
    {
        public UserForRegistrationDtoValidator()
        {
            RuleFor(user => user.UserName)
                .NotNull()
                .NotEmpty()
                .Length(Constants.UserNameMinLength, Constants.UserNameMaxLength);

            RuleFor(user => user.Email)
                .NotNull()
                .EmailAddress();


            RuleFor(user => user.Password)
                .NotNull()
                .NotEmpty();
        }
    }
}
