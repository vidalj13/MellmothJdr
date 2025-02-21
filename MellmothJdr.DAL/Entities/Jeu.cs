using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos;

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
