using FluentValidation;
using VeeMessenger.Data.Constants;
using VeeMessenger.Domain.Dto.User;

namespace VeeMessenger.Domain.FluentValidation.User
{
    public class UserForConfirmDtoValidator : AbstractValidator<UserForConfirmDto>
    {
        public UserForConfirmDtoValidator()
        {
            RuleFor(user => user.Email)
                .NotNull()
                .EmailAddress();

            RuleFor(user => user.Code)
                .Length(Constants.CodeLength)
                .Matches("[0-9]");
        }
    }
}
