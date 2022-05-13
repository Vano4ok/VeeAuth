namespace VeeMessenger.Data.Entities
{
    public class UserTempData : IEntity
    {
        public Guid Id { get; set; }

        public string EmailConfirmCode { get; set; }

        public int NumbersOfAttempts { get; set; }

        public User User { get; set; }
    }
}
