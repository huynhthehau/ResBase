namespace RestaurantManager.Domain.Entity
{
    public class BaseEntity
    {
        public virtual Guid Id { get; protected set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
