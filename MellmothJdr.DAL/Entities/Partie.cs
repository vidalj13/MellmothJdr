using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos;

using NotificationManager.Infrastructure.Entities.Base;

namespace MellmothJdr.DAL.Entities
{
    public class Partie : BaseEntity
    {
        public string Nom { get; set; }
        public int? NombreParticipant { get; set; }
        public Guid JeuId { get; set; }
        public Jeu Jeu { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<FichePersoChroniquesOublies> FichePersoChroniqueOublies { get; set; }
    }
}
