using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VeeMessenger.Data.Entities;
using VeeMessenger.Domain.Models.SettingsModels;
using VeeMessenger.Domain.Services.Interfaces;

namespace VeeMessenger.Domain.Services.Implementation
{
    public class AccessTokenService : IAccessTokenService
    {
        private readonly JwtSettings jwtSettings;

        public AccessTokenService(JwtSettings jwtSettings)
        {
            this.jwtSettings = jwtSettings;
        }

        public string GetAccessToken(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.AccessTokenSecret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken securityToken = new(jwtSettings.Issuer, jwtSettings.Audience,
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddMinutes(jwtSettings.AccessTokenExpirationMinutes),
                credentials);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
