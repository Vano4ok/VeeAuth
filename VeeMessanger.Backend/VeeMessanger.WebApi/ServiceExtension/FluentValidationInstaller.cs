using FluentValidation;
using VeeMessenger.Domain.Dto;
using VeeMessenger.Domain.Dto.User;
using VeeMessenger.Domain.FluentValidation;
using VeeMessenger.Domain.FluentValidation.User;

namespace VeeMessanger.WebApi.ServiceExtension
{
    public class FluentValidationInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IValidator<UserForConfirmDto>, UserForConfirmDtoValidator>();
            services.AddTransient<IValidator<UserForLoginDto>, UserForLoginDtoValidator>();
            services.AddTransient<IValidator<UserForRegistrationDto>, UserForRegistrationDtoValidator>();
            services.AddTransient<IValidator<RefreshTokensDto>, RefreshTokensDtoValidator>();
        }
    }
}
