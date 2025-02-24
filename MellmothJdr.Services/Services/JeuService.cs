using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using NotificationManager.Infrastructure;

namespace MellmothJdr.Services.Services;
public class JeuService : ServiceBase, IJeuService
{

    public JeuService(IServiceScopeFactory scopeFactory) : base(scopeFactory)
    {
    }

    public async Task AddFichePersoChroniquesOubliesAsync(FichePersoChroniquesOublies fichePersoChroniquesOublies, CancellationToken token)
    {
        using BddContexte bddContexte = GetScopedBddContexte();
        await bddContexte.FichesPersoChroniquesOublies.AddAsync(fichePersoChroniquesOublies, token);
        await bddContexte.SaveBaseEntityChangesAsync(token);
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

    public async Task<PartieDetailDto> GetPartieAsync(Guid idUserInterne, Guid gameId, Guid myGameId, CancellationToken token)
    {
        using BddContexte bddContexte = GetScopedBddContexte();
        return await bddContexte.Parties.Where(x => x.Id == myGameId && x.UserId == idUserInterne)
            .OrderByDescending(x => x.DateMaj)
            .Select(x => new PartieDetailDto()
            {
                Id = x.Id,
                Nom = x.Nom,
                Persos = gameId == Ids.Jeux.ChroniquesOublies ? x.FichePersoChroniqueOublies.Select(y => new PersoDto()
                {
                    Id = y.Id,
                    Nom = y.Nom,
                    RaceLibelle = y.RaceLibelle,
                    TailleCm = y.TailleCm,
                    PoidKg = y.PoidKg,
                    Age = y.Age,
                    Religion = y.Religion,
                    Niveau = y.Niveau,
                    PvMax = y.PvMax,
                    PvEnCours = y.PvEnCours
                }).ToList() : new List<PersoDto>(),
                NombreParticipant = x.NombreParticipant
            })
            .FirstAsync(token);
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
                NombrePerso = gameId == Ids.Jeux.ChroniquesOublies ? x.FichePersoChroniqueOublies.Count(y => y.UserId == idUserInterne) : 0, 
                NombreParticipant = x.NombreParticipant
            })
            .ToListAsync(token);
    }
}
