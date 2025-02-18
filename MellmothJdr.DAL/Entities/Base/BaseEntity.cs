namespace NotificationManager.Infrastructure.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; internal set; }
        public DateTime DateCrea { get; internal set; }
        public DateTime DateMaj { get; set; }
    }
}