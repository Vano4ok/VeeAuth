namespace VeeMessenger.Data.Entities
{
    public interface IEntityWithImage : IEntity
    {
        public string? ImageId { get; set; }
    }
}
