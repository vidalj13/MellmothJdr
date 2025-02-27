using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;

using NotificationManager.Infrastructure.Entities.Base;

namespace MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies
{
    public class FichePersoChroniquesOublies : BaseFichePersoEntity
    {

        public List<JoinFichePersoChroniquesOubliesClasse> JoinFichePersoChroniquesOubliesClasses { get; set; }
        public List<JoinFichePersoChroniquesOubliesVoie> JoinFichePersoChroniquesOubliesVoies { get; set; }
    }
}
