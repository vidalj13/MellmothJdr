using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;
namespace MellmothJdr.Pages.MesParties;

public class MesPartiesPage : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    protected JeuDto Jeu { get; set; }
    protected List<PartieDto> Elements { get; set; }
    protected string searchString1 = "";

    protected override async Task LoadAsync()
    {

        Task<JeuDto> TaskJeu = GetScopedService<IJeuService>().GetJeuxAsync(GameId, CancellationToken.None);
        Task<List<PartieDto>> TaskParties = GetScopedService<IJeuService>().GetPartiesAsync(IdUserInterne, GameId, CancellationToken.None);
        Jeu = await TaskJeu;
        Elements = await TaskParties;
    }


    protected bool FilterFunc1(PartieDto element) => FilterFunc(element, searchString1);

    private bool FilterFunc(PartieDto element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nom.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if ($"{element.NombrePerso} {element.NombreParticipant} ".Contains(searchString))
            return true;
        return false;
    }
}