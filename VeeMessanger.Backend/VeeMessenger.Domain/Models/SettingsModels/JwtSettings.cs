namespace VeeMessenger.Domain.Models.SettingsModels
{
    public class JwtSettings
    {
        public string AccessTokenSecret { get; set; } = string.Empty;

        public string RefreshTokenSecret { get; set; } = string.Empty;

        public double AccessTokenExpirationMinutes { get; set; }

        public double RefreshTokenExpirationMinutes { get; set; }

        public string Issuer { get; set; } = string.Empty;

        public string Audience { get; set; } = string.Empty;
    }
}
