using MellmothJdr.DAL.Entities.Jointures;

using NotificationManager.Infrastructure.Entities.Base;

namespace MellmothJdr.DAL.Entities.FichesPersos
{
    public class FichePersoChroniquesOublies : BaseFichePersoEntity
    {

        public List<JoinFichePersoChroniquesOubliesClasse> JoinFichePersoChroniquesOubliesClasses { get; set; }
    }
}
