using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Commun.Constantes;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;

namespace MellmothJdr.Pages.MesParties;

public class MesPartiesPage : AuthenticatedPartialPage
{
    [Inject]
    public IJeuService JeuService { get; set; }
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    protected JeuDto Jeu { get; set; }

    protected override async Task LoadAsync()
    {
        Jeu = await JeuService.GetJeuxAsync(GameId, CancellationToken.None);
    }
}