using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class TalentChroniquesOubliesConfiguration : IEntityTypeConfiguration<TalentChroniquesOublies>
    {
        DateTime dateInit = new(2025, 03, 12);
        public void Configure(EntityTypeBuilder<TalentChroniquesOublies> builder)
        {
            builder.ToTable("TalentChroniquesOublies");
            builder.ConfigureBaseEntity();

            builder.HasOne(x => x.Voie)
                .WithMany(x => x.TalentsChroniquesOubliesVoies)
                .HasForeignKey(x => x.VoieId);

            List<TalentChroniquesOublies> data = new List<TalentChroniquesOublies>();
            //PopulateArquebusier(data);
            //PopulateBarbare(data);
            //PopulateBarde(data);
            //PopulateChevalier(data);
            //PopulateDruide(data);
            //PopulateEnsorceleur(data);
            //PopulateWar(data);
            //PopulateForgesort(data);
            //PopulateMagicien(data);
            //PopulatePretre(data);
            //PopulateMoine(data);
            //PopulateRodeur(data);
            //PopulateVoleur(data);
            //PopulateNecromancien(data);
            builder.HasData(
                data);

        }
        /*
            new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "",
                    Description = "",
                    Rang = ,
                    IsLimitant = false,
                    Id  = new Guid(""),
                },
        */
        private void PopulateArquebusier(List<TalentChroniquesOublies> data)
        {
            data.AddRange(new List<TalentChroniquesOublies>()
            {
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Mécanismes",
                    Description = "L’Arquebusier obtient un bonus de +1 par Rang dans cette voie à tous les tests visant à réparer ou à comprendre des mécanismes (cela inclut le fait de désamorcer des pièges mécaniques et de manipuler des armes de siège). Il peut appliquer ce bonus à tous les tests d’attaque avec des armes de siège (baliste, couleuvrine, canon, trébuchet, catapulte, etc.).",
                    Rang = 1,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Tir de semonce",
                    Description = "Après avoir raté une attaque à distance au tour précédent, l’Arquebusier déclare qu’il s’agissait d’un tir de semonce. À ce tour, il tire sur la même cible et obtient +5 à son test et +1d6 aux DM sur sa première attaque.",
                    Rang = 2,
                    IsLimitant = true,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Tir de Barrage",
                    Description = "L’Arquebusier met en joue une cible sur laquelle il a l’Initiative et attend. Si elle se déplace à ce tour, il effectue une attaque à distance. En cas de succès la victime choisit entre deux possibilités : soit elle subit double dégâts, soit elle ne se déplace pas et ne subit pas de dégâts, tout en perdant son tour.",
                    Rang = 3,
                    IsLimitant = true,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Couleuvrine",
                    Description = "L'Arquebusier obtient une couleuvrine, un petit canon portatif qui nécessite la mise en place d’un trépied (ou d’un appui). Utiliser cette arme demande une action limitée et ne peut avoir lieu qu’une seule fois par combat. Sur un test d’attaque à distance réussi, elle inflige [4d6 + Mod. de DEX] DM. La portée maximale de cette arme est de 100 mètres et sa portée minimale de 10 mètres.",
                    Rang = 4,
                    IsLimitant = true,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Artilleur,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Feu Nourri",
                    Description = "Lorsqu’il utilise le Tir de barrage, l’Arquebusier peut affecter jusqu’à [1 + Mod. de DEX] cibles différentes dans le même tour. Toutes les cibles doivent être dans une zone frontale de 20 mètres de large au maximum. Chaque cible donne lieu à un test d’attaque à distance indépendant.",
                    Rang = 5,
                    IsLimitant = false,
                    Id  = new Guid(""),
                },

                
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Explosifs‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Chimiste",
                    Description = "L’Arquebusier sait fabriquer sa propre poudre et d’autres substances explosives, et obtient un bonus de +2 par Rang à tous les tests de chimie ou d’alchimie. Les armes à poudre du personnage ne présentent plus de risque de « faire long feu » ou d’explosion et le joueur ne lance plus de dé de poudre.",
                    Rang = 1,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Explosifs‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Démolition",
                    Description = "L’Arquebusier peut préparer un explosif qui lui permet de démolir facilement des structures. Il lui faut 3 tours complets pour préparer et poser son explosif. Celui-ci inflige à la structure 2d6 DM par Rang dans la voie et 1d6 par rang dans un rayon de 6 mètres autour (en ignorant la moitié de la RD de la structure. Voir DM aux structures).",
                    Rang = 2,
                    IsLimitant = false,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Explosifs‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Poudre puissante",
                    Description = "L’Arquebusier sait préparer lui-même une poudre plus puissante, il ajoute +10 mètres à la portée et +2 aux dégâts de toutes ses armes à poudre.",
                    Rang = 3,
                    IsLimitant = false,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Explosifs‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Piège explosif",
                    Description = "il faut un tour complet à l’Arquebusier pour installer un piège qui explose dans un rayon de 3 mètres en infligeant 5d6 DM (test de DEX difficulté 15 pour ne subir que la moitié des DM). L’Arquebusier peut choisir entre deux modes de déclenchement, soit avec un retardateur allant de 1 à 10 tours au choix, soit à l’intrusion de toute créature dans une zone d’1 mètre autour du piège. Cette seconde solution demande 1 tour de préparation supplémentaire et un personnage attentif peut détecter et éviter le piège avec un test de SAG difficulté [12 + Mod. d’INT de l’Arquebusier].",
                    Rang = 4,
                    IsLimitant = true,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.Explosifs‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Boulet explosif",
                    Description = "L’Arquebusier sait fabriquer et lancer de petites boules de métal munies de poudre et d’une mèche. Un tel projectile a une portée de 20 mètres et explose dans un rayon de 5 mètres en infligeant 5d6 DM, divisé par 2 pour les victimes qui réussissent un test de DEX difficulté [12 + Mod. de DEX de l’Arquebusier].",
                    Rang = 5,
                    IsLimitant = true,
                    Id  = new Guid(""),
                },

                
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.ChampsDeBataille‎‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Action concertée",
                    Description = "Une fois par tour, l’Arquebusier peut échanger son Initiative avec un autre personnage volontaire. S’il cède son Initiative à un personnage plus lent, il gagne un bonus de +1 sur ses tests d’attaque à ce tour. Ce bonus passe à +2 au Rang 4 de la voie.",
                    Rang = 1,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.ChampsDeBataille‎‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "A couvert",
                    Description = "Jusqu’à son prochain tour, l’Arquebusier divise par 2 les DM dus aux attaques à distance et de zone qu’il reçoit, et peut se déplacer de 20 mètres. Un compagnon de l’Arquebusier peut profiter de cette aptitude s’il a son accord et reste à son contact.",
                    Rang = 2,
                    IsLimitant = true,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.ChampsDeBataille‎‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Combattant aguerri",
                    Description = "L’Arquebusier peut choisir n’importe quelle capacité de rang 2 d’une voie de Guerrier de son choix et gagne 3 PV supplémentaires. Il peut choisir une capacité de Rang 1 seulement et gagne alors 6 PV au lieu de 3.",
                    Rang = 3,
                    IsLimitant = false,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.ChampsDeBataille‎‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Combat de masse",
                    Description = "L'Arquebusier obtient une action de mouvement ou une action d’attaque supplémentaire à chaque tour si le combat implique au moins 10 créatures (en comptant l’Arquebusier et ses alliés).",
                    Rang = 4,
                    IsLimitant = false,
                    Id  = new Guid(""),
                },
                new()
                {
                    VoieId =  Ids.ChroniqueOublie.Voie.ChampsDeBataille‎‎,
                    DateCrea = dateInit,
                    DateMaj = dateInit,
                    Libelle = "Constitution héroïque",
                    Description = "Le personnage augmente son score de CON de +2 et il peut désormais lancer deux d20 à chaque fois qu’un test de CON lui est demandé et conserver le meilleur résultat.",
                    Rang = 5,
                    IsLimitant = false,
                    Id  = new Guid(""),
                },
            });
        }
    }
}
