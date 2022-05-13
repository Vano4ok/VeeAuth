using Microsoft.EntityFrameworkCore;
using VeeMessenger.Data.Context;
using VeeMessenger.Data.Entities;
using VeeMessenger.Data.Infrastructure;
using VeeMessenger.Domain.Services.Implementation;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessanger.WebApi.ServiceExtension
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VeeMessengerContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("sqlConnection"), x => x.MigrationsAssembly("VeeMessenger.Data")));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IAuthenticationErrorDescriberService, AuthenticationErrorDescriberService>();
            services.AddScoped<IPasswordHasherService, PasswordHasherService>();
            services.AddScoped<IAccessTokenService, AccessTokenService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IPasswordValidationService, PasswordValidationService>();
            services.AddScoped<IUserNameValidationService, UserNameValidationService>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();
            services.AddScoped<ICodeGeneratorService, CodeGeneratorService>();
            services.AddScoped<IRefreshSessionService, RefreshSessionService>();

            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IRepository<RefreshSession>, Repository<RefreshSession>>();
        }
    }
}
