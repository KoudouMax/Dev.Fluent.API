namespace Dev.Fluent.Common.Models
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public EntityBase()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
