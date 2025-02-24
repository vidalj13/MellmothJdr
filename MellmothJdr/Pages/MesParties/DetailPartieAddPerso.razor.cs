using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.Pages.Persos;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;

using NotificationManager.Infrastructure.Entities.Base;
namespace MellmothJdr.Pages.MesParties;

public class DetailPartieAddPersoPage : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    [Parameter]
    public Guid MyGameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    protected List<Race> Races { get; set; } = new List<Race>();
    public BaseFichePersoFormComponent FormBase { get; set; }
    public BaseFichePersoEntity BaseFichePerso { get; set; } = new();
    public FichePersoChroniquesOublies FichePersoChroniquesOublies { get; set; } = new();
    protected override async Task LoadAsync()
    {
        Task<List<Race>> taskRaces = GetScopedService<IRaceService>().GetRacesAsync(GameId, CancellationToken.None);
        Races = await taskRaces;
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
        if(!FormBase.IsRaceCustom)
        {
            FichePersoChroniquesOublies.RaceLibelle = FichePersoChroniquesOublies.Race.RaceLibelle;
        }
        await GetScopedService<IJeuService>().AddFichePersoChroniquesOubliesAsync(FichePersoChroniquesOublies, CancellationToken.None);
    }

    protected void Back()
    {
        Navigation.NavigateTo(Routes.MyGamesDetailsTemplate.Replace("{GameId:guid}", GameId.ToString()).Replace("{MyGameId:guid}", MyGameId.ToString()), true);
    }
}