using MellmothJdr.DAL.Entities.Base;

namespace MellmothJdr.DAL.Entities
{
    public class ArmeStart : BaseEntity
    {
        public string Libelle { get; set; }
        public int? PorteEnM { get; set; }
        public int? DeAttaque  { get; set; }
        public int? Quantite { get; set; }
        public int? ModificateurDef { get; set; }
        public int? NombreDeAttaque { get; set; }
        public int? MinCritique { get; set; }

        public Guid ClasseId { get; set; }
        public Classe Classe { get; set; }
    }  
}