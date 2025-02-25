using MellmothJdr.DAL.Entities;
using MellmothJdr.Services.IServices;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using NotificationManager.Infrastructure;

namespace MellmothJdr.Services.Services;

public class ClasseService : ServiceBase, IClasseService
{

    public ClasseService(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
    }

    public async Task<List<Classe>> GetClassesAsync(Guid gameId, CancellationToken none)
    {
        using BddContexte contexte = GetScopedBddContexte();
        List<Classe> classes = await contexte.Classes
                                    .Where(x => x.JeuId == gameId)
                                    .OrderBy(x => x.Libelle)
                                    .ToListAsync(none);
        return classes;
    }
}
