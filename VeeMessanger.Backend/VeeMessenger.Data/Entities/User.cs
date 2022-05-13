namespace VeeMessenger.Data.Entities
{
    public class User : IEntityWithImage
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public bool EmailConfirmed { get; set; } = false;

        public string Bio { get; set; } = string.Empty;

        public string? ImageId { get; set; }

        public DateTime LockOutDate { get; set; }

        public string PasswordHash { get; set; }

        public UserTempData UserTempData { get; set; } = new UserTempData();

        public ICollection<RefreshSession> RefreshSessions { get; set; } = new List<RefreshSession>();
    }
}
