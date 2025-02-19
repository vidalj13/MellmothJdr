using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Commun.Constantes;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;
namespace MellmothJdr.Pages.DnD;

public class DnDHomePage : AuthenticatedPartialPage
{
    [Inject]
    public IJeuService JeuService { get; set; }
    protected JeuDto Jeu { get; set; }

    protected override async Task LoadAsync()
    {
        Jeu = await JeuService.GetJeuxAsync(Ids.Jeux.DnD, CancellationToken.None);
    }
}