using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.Pages.Persos;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;

using MudBlazor;

using NotificationManager.Infrastructure.Entities.Base;

using static MudBlazor.CategoryTypes;
namespace MellmothJdr.Pages.MesParties;

public class DetailPartieAddPersoPage : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    [Parameter]
    public Guid MyGameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid

    public BaseFichePersoFormComponent FormBase { get; set; }
    public BaseFichePersoEntity BaseFichePerso { get; set; } = new();
    public FichePersoChroniquesOublies FichePersoChroniquesOublies { get; set; } = new();
    protected override async Task LoadAsync()
    {

    }

    protected async Task Save()
    {
        await FormBase.Validate();
        if (FormBase.IsValid)
        {
            if(GameId == Ids.Jeux.ChroniquesOublies)
            {
                await SaveChroniqueOublieAsync();
                Back();
            }
        }
    }

    private async Task SaveChroniqueOublieAsync()
    {
        FichePersoChroniquesOublies.UserId = IdUserInterne;
        FichePersoChroniquesOublies.JeuId = GameId;
        FichePersoChroniquesOublies.PartieId = MyGameId;
        FichePersoChroniquesOublies.PvEnCours = FichePersoChroniquesOublies.PvMax;
        await GetScopedService<IJeuService>().AddFichePersoChroniquesOubliesAsync(FichePersoChroniquesOublies, CancellationToken.None);
    }

    protected void Back()
    {
        Navigation.NavigateTo(Routes.MyGamesDetailsTemplate.Replace("{GameId:guid}", GameId.ToString()).Replace("{MyGameId:guid}", MyGameId.ToString()), true);
    }
}