using FluentValidation;
using VeeMessenger.Data.Constants;
using VeeMessenger.Domain.Dto.User;

namespace VeeMessenger.Domain.FluentValidation.User
{
    public class UserForLoginDtoValidator : AbstractValidator<UserForLoginDto>
    {
        public UserForLoginDtoValidator()
        {
            RuleFor(user => user.UserName)
                .NotNull()
                .NotEmpty()
                .Length(Constants.UserNameMinLength, Constants.UserNameMaxLength);

            RuleFor(user => user.Password)
                .NotNull()
                .NotEmpty();
        }
    }
}
