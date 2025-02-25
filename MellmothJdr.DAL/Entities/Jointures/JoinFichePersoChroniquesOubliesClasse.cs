using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos;

namespace MellmothJdr.DAL.Entities.Jointures
{
    public class JoinFichePersoChroniquesOubliesClasse : BaseEntity
    {
        public Guid ClasseId { get; set; }
        public Classe Classe { get; set; }
        public Guid FichePersoChroniquesOubliesId { get; set; }
        public FichePersoChroniquesOublies FichePersoChroniquesOublies { get; set; }
    }
}