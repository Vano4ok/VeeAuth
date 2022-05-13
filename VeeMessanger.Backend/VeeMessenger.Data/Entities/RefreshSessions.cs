namespace VeeMessenger.Data.Entities
{
    public class RefreshSession : IEntity
    {
        public Guid Id { get; set; }

        public string FingerPrint { get; set; }

        public DateTime Expires { get; set; }

        public DateTime Created { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

    }
}
