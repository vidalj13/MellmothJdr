using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos;
using MellmothJdr.Pages.Persos;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;

using MudBlazor;

using NotificationManager.Infrastructure.Entities.Base;
namespace MellmothJdr.Pages.MesParties;

public class DetailPartieAddPersoPage : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    [Parameter]
    public Guid MyGameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    protected List<Race> Races { get; set; } = new List<Race>();
    protected List<Classe> Classes { get; set; } = new List<Classe>();
    public BaseFichePersoFormComponent FormBase { get; set; }
    public BaseFichePersoEntity BaseFichePerso { get; set; } = new();
    public FichePersoChroniquesOublies FichePersoChroniquesOublies { get; set; } = new()
    {
        Niveau = 1,
        PoidKg = 30,
        Age = 25,
        TailleCm = 182,
        PvMax = 10
    };
    public MudForm Form { get; set; }
    public Classe ClasseSelected { get; set; }
    protected override async Task LoadAsync()
    {
        Task<List<Race>> taskRaces = GetScopedService<IRaceService>().GetRacesAsync(GameId, CancellationToken.None);
        Task<List<Classe>> taskClasses= GetScopedService<IClasseService>().GetClassesAsync(GameId, CancellationToken.None);
        Races = await taskRaces;
        Classes = await taskClasses;
    }

    protected async Task Save()
    {
        await FormBase.Validate();
        await Form.Validate();
        if (FormBase.IsValid && Form.IsValid)
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
        FichePersoChroniquesOublies.JoinFichePersoChroniquesOubliesClasses = new List<DAL.Entities.Jointures.JoinFichePersoChroniquesOubliesClasse>()
        {
            new DAL.Entities.Jointures.JoinFichePersoChroniquesOubliesClasse()
            {
                ClasseId = ClasseSelected.Id
            }
        };
        if(!FormBase.IsRaceCustom)
        {
            FichePersoChroniquesOublies.RaceLibelle = FichePersoChroniquesOublies.Race.RaceLibelle;
            FichePersoChroniquesOublies.RaceId = FichePersoChroniquesOublies.Race.Id;
            FichePersoChroniquesOublies.Race = null;
        }
        await GetScopedService<IJeuService>().AddFichePersoChroniquesOubliesAsync(FichePersoChroniquesOublies, CancellationToken.None);
    }

    protected void Back()
    {
        Navigation.NavigateTo(Routes.MyGamesDetailsTemplate.Replace("{GameId:guid}", GameId.ToString()).Replace("{MyGameId:guid}", MyGameId.ToString()), true);
    }
}