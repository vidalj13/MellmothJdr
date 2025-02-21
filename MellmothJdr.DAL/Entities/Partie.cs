using MellmothJdr.DAL.Entities;

using NotificationManager.Infrastructure.Entities.Base;

namespace NotificationManager.Infrastructure.Entities
{
    public class Partie : BaseEntity
    {
        public string Nom { get; set; }
        public int? NombreParticipant { get; set; }
        public Guid JeuId { get; set; }
        public Jeu Jeu {  get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
