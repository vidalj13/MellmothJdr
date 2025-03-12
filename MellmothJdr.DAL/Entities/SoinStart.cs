using MellmothJdr.DAL.Entities.Base;

namespace MellmothJdr.DAL.Entities
{
    public class SoinStart : BaseEntity
    {
        public string Libelle { get; set; }
        public int? DeSoin  { get; set; }
        public int? NombreDeSoin { get; set; }
        public int? MinCritique { get; set; }

        public Guid ClasseId { get; set; }
        public Classe Classe { get; set; }
    }
}