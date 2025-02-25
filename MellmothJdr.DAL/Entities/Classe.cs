using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.DAL.Entities.Jointures;

namespace MellmothJdr.DAL.Entities
{
    public class Classe : BaseEntity
    {
        public string Libelle { get; set; }
        public string Description { get; set; }
        public Guid JeuId { get; set; }
        public Jeu Jeu { get; set; }

        public List<JoinFichePersoChroniquesOubliesClasse> JoinFichePersoChroniquesOubliesClasses { get; set; }
    }
}