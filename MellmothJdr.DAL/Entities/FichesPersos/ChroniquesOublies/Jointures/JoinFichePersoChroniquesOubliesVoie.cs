using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;

namespace MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures
{
    public class JoinFichePersoChroniquesOubliesVoie : BaseEntity
    {
        public Guid VoieId { get; set; }
        public VoieChroniquesOublies Voie { get; set; }
        public Guid FichePersoChroniquesOubliesId { get; set; }
        public FichePersoChroniquesOublies FichePersoChroniquesOublies { get; set; }
    }
}