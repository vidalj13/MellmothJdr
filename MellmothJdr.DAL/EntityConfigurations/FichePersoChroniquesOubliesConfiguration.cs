using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seedwork.EntityFramework.Extensions;

namespace NotificationManager.Infrastructure.EntityConfigurations
{
    internal class FichePersoChroniquesOubliesConfiguration : IEntityTypeConfiguration<FichePersoChroniquesOublies>
    {
        public void Configure(EntityTypeBuilder<FichePersoChroniquesOublies> builder)
        {
            builder.ToTable("FichesPersoChroniquesOublies");

            System.Linq.Expressions.Expression<Func<Race, IEnumerable<FichePersoChroniquesOublies>>> navigationExpressionRaces = x => x.FichesPersoChroniquesOublies;
            System.Linq.Expressions.Expression<Func<Jeu, IEnumerable<FichePersoChroniquesOublies>>> navigationExpressionJeux = x => x.FichesPersoChroniquesOublies;
            System.Linq.Expressions.Expression<Func<Partie, IEnumerable<FichePersoChroniquesOublies>>> navigationExpressionParties = x => x.FichePersoChroniqueOublies;
            System.Linq.Expressions.Expression<Func<User, IEnumerable<FichePersoChroniquesOublies>>> navigationExpressionUsers = x => x.FichePersoChroniqueOublies;
            builder.ConfigureBaseFichePersoEntity(navigationExpressionRaces, navigationExpressionParties, navigationExpressionJeux,navigationExpressionUsers);



        }
    }
}
