using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;
namespace MellmothJdr.Pages.MesParties;

public class DetailPartiePage : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    [Parameter]
    public Guid MyGameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    protected JeuDto Jeu { get; set; }
    protected PartieDetailDto Partie { get; set; }
    protected List<PersoDto> Persos => Partie.Persos;

    protected override async Task LoadAsync()
    {
        Task<JeuDto> TaskJeu = GetScopedService<IJeuService>().GetJeuxAsync(GameId, CancellationToken.None);
        Task<PartieDetailDto> TaskParties = GetScopedService<IJeuService>().GetPartieAsync(IdUserInterne, GameId, MyGameId, CancellationToken.None);
        Jeu = await TaskJeu;
        Partie = await TaskParties;
    }
}