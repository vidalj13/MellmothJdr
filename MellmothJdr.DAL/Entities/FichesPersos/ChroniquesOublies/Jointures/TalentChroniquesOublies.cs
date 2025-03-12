using MellmothJdr.DAL.Entities.Base;

namespace MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures
{
    public class TalentChroniquesOublies : BaseEntity
    {
        public Guid VoieId { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public int Rang { get; set; }
        public VoieChroniquesOublies Voie { get; set; }
    }
}