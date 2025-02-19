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
}
