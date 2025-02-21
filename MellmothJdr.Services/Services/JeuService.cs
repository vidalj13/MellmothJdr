using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using NotificationManager.Infrastructure;
using NotificationManager.Infrastructure.Entities;

namespace MellmothJdr.Services.Services;

public class JeuService : ServiceBase, IJeuService
{

    public JeuService(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
    }

    public async Task AddPartiesAsync(Partie newPartie, CancellationToken token)
    {
        using BddContexte bddContexte = GetScopedBddContexte();
        await bddContexte.Parties.AddAsync(newPartie, token);
        await bddContexte.SaveBaseEntityChangesAsync(token);
    }

    public async Task<JeuDto> GetJeuxAsync(Guid id, CancellationToken token)
    {
        using BddContexte contexte = GetScopedBddContexte();
        JeuDto retour = await contexte.Jeux.Where(x => x.Id == id).Select(x => new JeuDto()
        {
            Nom = x.Nom,
            Description = x.Description,
        }).SingleAsync(token);
        return retour;
    }

    public async Task<List<PartieDto>> GetPartiesAsync(Guid idUserInterne, Guid gameId, CancellationToken token)
    {
        using BddContexte bddContexte = GetScopedBddContexte();
        return await bddContexte.Parties.Where(x => x.UserId == idUserInterne && x.JeuId == gameId)
            .OrderByDescending(x => x.DateMaj)
            .Select(x => new PartieDto()
            {
                Id = x.Id,
                Nom = x.Nom,
                NombrePerso = 0,
                NombreParticipant = x.NombreParticipant
            })
            .ToListAsync(token);
    }
}
