using MellmothJdr.DAL.Entities.FichesPersos;

using NotificationManager.Infrastructure.Entities;
using NotificationManager.Infrastructure.Entities.Base;

namespace MellmothJdr.DAL.Entities
{
    public class Jeu : BaseEntity
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public List<Partie> Parties { get; set; }
        public List<Race> Races { get; set; }
        public List<FichePersoChroniquesOublies> FichesPersoChroniquesOublies { get; set; }
    }
}
