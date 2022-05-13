using FluentValidation;
using VeeMessenger.Domain.Dto;

namespace VeeMessenger.Domain.FluentValidation
{
    public class RefreshTokensDtoValidator : AbstractValidator<RefreshTokensDto>
    {
        public RefreshTokensDtoValidator()
        {
            RuleFor(refreshTokensDto => refreshTokensDto.FingerPrint)
                .NotNull()
                .NotEmpty();
        }
    }
}
