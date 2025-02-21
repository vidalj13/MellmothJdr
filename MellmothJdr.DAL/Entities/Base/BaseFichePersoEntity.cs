using MellmothJdr.DAL.Entities;

namespace NotificationManager.Infrastructure.Entities.Base
{
    public class BaseFichePersoEntity : BaseEntity
    {
        public string Nom { get; set; }
        public string RaceLibelle { get; set; }
        public int TailleCm { get; set; }
        public int PoidKg { get; set; }
        public int Age { get; set; }
        public string Religion { get; set; }
        public int Niveau { get; set; }
        public int PvMax { get; set; }
        public int PvEnCours { get; set; }

        public Guid? RaceId { get; set; }
        public Race Race { get; set; }
        public Guid? JeuId { get; set; }
        public Jeu Jeu { get; set; }
    }
}