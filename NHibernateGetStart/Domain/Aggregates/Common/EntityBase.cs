namespace NHibernateGetStart.Domain.Aggregates.Common
{
    public class EntityBase
    {
        public EntityBase() => CreatedAt = DateTime.UtcNow;

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; private set; }

        public virtual void Delete() => IsDeleted = true;
    }
}
