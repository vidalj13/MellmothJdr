﻿using MellmothJdr.DAL.Entities.Base;
using MellmothJdr.DAL.Entities.FichesPersos;

namespace MellmothJdr.DAL.Entities
{
    public class Race : BaseEntity
    {
        public string RaceLibelle { get; set; }
        public Guid JeuId { get; set; }
        public Jeu Jeu { get; set; }

        public List<FichePersoChroniquesOublies> FichesPersoChroniquesOublies { get; set; }
    }
}