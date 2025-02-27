using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;

namespace MellmothJdr.DAL.Entities
{
    public class User : BaseEntity
    {
        public string ExterneId { get; set; }
        public List<Partie> Parties { get; set; }
        public List<FichePersoChroniquesOublies> FichePersoChroniqueOublies { get; set; }
    }
}
