using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;

namespace MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies
{
    public class VoieChroniquesOublies : BaseEntity
    {
        public string Libelle { get; set;}
        public List<JoinFichePersoChroniquesOubliesVoie> JoinFichePersoChroniquesOubliesVoies { get; set; }

        public Guid ClasseId { get; set;}
        public Classe Classe { get; set;}

    }
}
