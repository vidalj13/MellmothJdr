using MellmothJdr.DAL.Entities;
using MellmothJdr.Services.IServices;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using NotificationManager.Infrastructure;

namespace MellmothJdr.Services.Services;

public class RaceService : ServiceBase, IRaceService
{

    public RaceService(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
    }

    public async Task<List<Race>> GetRacesAsync(Guid gameId, CancellationToken none)
    {
        using BddContexte contexte = GetScopedBddContexte();
        List<Race> races = await contexte.Races.Where(x => x.JeuId == gameId)
                                    .OrderBy(x => x.RaceLibelle).ToListAsync(none);
        return races;
    }
}
