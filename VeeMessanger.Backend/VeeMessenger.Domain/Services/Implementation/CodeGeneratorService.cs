using System.Security.Cryptography;
using VeeMessenger.Data.Constants;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class CodeGeneratorService : ICodeGeneratorService
    {
        public string GenerateNumberCode()
        {
            return RandomNumberGenerator.GetInt32(Constants.CodeMin, Constants.CodeMax).ToString();
        }
    }
}
