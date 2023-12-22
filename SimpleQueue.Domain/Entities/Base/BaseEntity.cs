namespace SimpleQueue.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
    }

    public enum EntityStatus
    {
        Active,
        Inactive,
    }
}