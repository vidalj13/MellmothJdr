using NotificationManager.Infrastructure.Entities.Base;

namespace NotificationManager.Infrastructure.Entities
{
    public class User : BaseEntity
    {
        public string ExterneId { get; set; }
        public List<Partie> Parties { get; set; }
    }
}
