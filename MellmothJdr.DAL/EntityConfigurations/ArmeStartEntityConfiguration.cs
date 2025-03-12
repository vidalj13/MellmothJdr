using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class ArmeStartEntityConfiguration : IEntityTypeConfiguration<ArmeStart>
    {
        public void Configure(EntityTypeBuilder<ArmeStart> builder)
        {
            builder.ToTable("ArmeStart");
            builder.ConfigureBaseEntity();

            builder.Property(x => x.Libelle)
                .HasColumnType("varchar(200)");

            builder.HasOne(x => x.Classe)
                .WithMany(x => x.ArmesStarts)
                .HasForeignKey(x => x.ClasseId);

            DateTime dateInit = new(2025, 02, 25);
            builder.HasData(
                new List<ArmeStart>() {
                    new()
                    {
                        Libelle = "Pétoire",
                        Id = new Guid("626B4CBC-24FD-4CF4-B0B8-6CE09644A9E1"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Arquebusier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 10,
                        PorteEnM = 20,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid("7B82ED7E-BA93-4373-939E-28AC1721C088"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Arquebusier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NombreDeAttaque = 1,
                        PorteEnM = null
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("E71E64CA-B497-45DC-B4B3-40F89A28540E"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Arquebusier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                        PorteEnM = null
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("BF7E1989-9173-4E2C-84C3-0A12F089C3E1"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barbare,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                        PorteEnM = null
                    },   new()
                    {
                        Libelle = "Hache à 2 mains",
                        Id = new Guid("FD4B96F6-715A-43AB-9113-3CC1273AA66B"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barbare,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 2,
                        PorteEnM = null
                    },   new()
                    {
                        Libelle = "Javelots",
                        Id = new Guid("739F46E1-8EF3-4F2A-926A-B5A04AD8D867"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barbare,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        Quantite = 2,
                        NombreDeAttaque = 1,
                        PorteEnM = 20
                    },
                    new()
                    {
                        Libelle = "Rapière",
                        Id = new Guid("DEEDD7E0-F790-4ADA-B987-D95B9C09D45B"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barde,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1,
                        MinCritique = 19
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("9E473523-4C62-42C1-884B-E7F72048894A"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barde,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Instrument de musique",
                        Id = new Guid("C3CE1D4D-9A6F-4D5D-B2A6-DCCF92AFB9C2"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Barde,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid("7888A9A2-D597-4A0F-8CBB-CCB6E5422F95"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NombreDeAttaque = 1,
                        PorteEnM = null
                    },
                    new()
                    {
                        Libelle = "Grand bouclier",
                        Id = new Guid("BB7C369A-6100-4489-A322-D09A5ED6B817"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ModificateurDef = 2,
                    },
                    new()
                    {
                        Libelle = "Lance de cavalerie",
                        Id = new Guid("9B57D933-1E10-4DB7-84FC-5000CA09B095"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 2
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("61FCD1A9-4B67-4AFA-A7BB-CAEE1F26FC34"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Chevalier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Bâton",
                        Id = new Guid("A6C8A462-465C-4B63-B2BD-4FFD608FB3E9"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Druide,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("694D75CA-3359-4C28-8090-9C0E61A120E4"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Druide,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Arc court",
                        Id = new Guid("6EC5814D-5D81-4663-B4FD-64C387533E1C"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Druide,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1,
                        PorteEnM = 30
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid("C376C16C-9A4A-4207-9C90-4A567D58753E"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Ensorceleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("E00EA4C0-9A49-4188-9561-5FD7851DBC2C"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Ensorceleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("51EB1CF4-819E-4CE7-8F9F-7FD11342DBDB"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Forgesort,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid("CE5FE204-9C4D-4B53-AC11-00C6B2C0EE6F"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Forgesort,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Marteau",
                        Id = new Guid("C8E989C4-158B-4BA6-8D6C-822299AFC517"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Forgesort,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid("7DA8F40C-DA14-4E51-804B-9A27AF8B9741"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Guerrier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée ou hache à 2 mains",
                        Id = new Guid("D5C3180C-DC53-4A22-9983-029F419C3675"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Guerrier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 2
                    },
                    new()
                    {
                        Libelle = "Grand bouclier",
                        Id = new Guid("777D590E-1E13-45FE-91FF-0A422C049179"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Guerrier,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ModificateurDef = 2,
                    },
                    new()
                    {
                        Libelle = "Bâton",
                        Id = new Guid("070A2AFB-BE78-439A-9F03-D55BE60DC134"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Grimoire",
                        Id = new Guid("4FFA6680-D4C9-49C7-A29C-04B7C53560E9"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("F4C633BB-6BA5-4AF7-B971-6700E7A9B5BC"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Magicien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid("A2FBF4A2-79C9-4A67-82E5-871E3F8DB310"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Moine,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("61621A26-7C3E-48A2-84F3-D61A76442657"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Necromancien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Bâton ferré",
                        Id = new Guid("DB9A9371-B414-4BB6-9263-AEF7EF3377F1"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Necromancien,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6 ,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Petit bouclier",
                        Id = new Guid("AA4F1BDB-8BA9-4030-A05A-573F468B5206"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Pretre,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        ModificateurDef = 1,
                    },
                    new()
                    {
                        Libelle = "Marteau ou masse de guerre",
                        Id = new Guid("307DE95A-45FD-45D0-9E6D-00554AC8F63D"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Pretre,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1
                    },
                    new()
                    {
                        Libelle = "Épée longue",
                        Id = new Guid("B97EC6DA-26A1-45FA-AF1A-278352A3216F"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rodeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 8,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Arc court",
                        Id = new Guid("CDF4943D-FEDF-4B6C-BDCD-E48756543CB3"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rodeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1,
                        PorteEnM = 30
                    },
                    new()
                    {
                        Libelle = "Dague",
                        Id = new Guid("0FDF20F9-4279-4FE7-A73C-4BA7D4FDB5BE"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rodeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                    },
                    new()
                    {
                        Libelle = "Carquois",
                        Id = new Guid("E2F5F54A-EB6E-4656-BF62-12FD17FD4A79"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Rodeur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                    },
                    new()
                    {
                        Libelle = "Dague de jet",
                        Id = new Guid("CD0DE432-6A9D-4EB3-B2B4-62834F8684FA"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Voleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        Quantite = 5,
                        DeAttaque = 4,
                        NombreDeAttaque = 1,
                        PorteEnM = 5
                    },
                    new()
                    {
                        Libelle = "Rapière",
                        Id = new Guid("94B9F9A9-BD23-46E5-863D-B3B5B63D1F6C"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Voleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit,
                        DeAttaque = 6,
                        NombreDeAttaque = 1,
                        MinCritique = 19
                    },
                    new()
                    {
                        Libelle = "Outils de crochetage",
                        Id = new Guid("BE17EA3B-4132-468E-9BB4-B58AE3921E48"),
                        ClasseId = Ids.ChroniqueOublie.Classe.Voleur,
                        DateCrea = dateInit,
                        DateMaj = dateInit
                    },
                });
        }
    }
}
