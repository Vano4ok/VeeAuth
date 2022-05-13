namespace VeeMessenger.Domain.Services.Interfaces
{
    public interface IPasswordHasherService
    {
        public string Hash(string password);

        public bool Check(string hash, string password);
    }
}
