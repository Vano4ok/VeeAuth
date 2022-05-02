namespace VeeMessanger.WebApi.ServiceExtension
{
    public interface IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
