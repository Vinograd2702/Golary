namespace Golary.Domain
{
    // Базовая  сущность с полем Id и UserId
    public class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public virtual Guid UserId { get; set; }
    }
}
