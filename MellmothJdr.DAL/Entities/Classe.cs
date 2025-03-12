using System.Security.Cryptography.X509Certificates;

using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;

namespace MellmothJdr.DAL.Entities
{
    public class Classe : BaseEntity
    {
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string ArmeArmure { get; set; }
        public string ArmureStart { get; set; }
        public int ModificateurArmureStart { get; set; }

        public Guid JeuId { get; set; }
        public Jeu Jeu { get; set; }

        public List<JoinFichePersoChroniquesOubliesClasse> JoinFichePersoChroniquesOubliesClasses { get; set; }
        public List<VoieChroniquesOublies> VoieChroniquesOublies { get; set; }
        public List<ArmeStart> ArmesStarts { get; set; }
        public List<SoinStart> SoinsStarts { get; set; }
    }
}