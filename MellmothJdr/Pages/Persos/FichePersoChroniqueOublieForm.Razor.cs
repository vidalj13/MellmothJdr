using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using MudBlazor;

using NotificationManager.Infrastructure.Entities.Base;
using MellmothJdr.BlazorBase.Pages;
namespace MellmothJdr.Pages.Persos;

public class FichePersoChroniqueOublieFormComponent : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    [Parameter]
    public Guid MyGameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    protected List<Race> Races { get; set; } = new List<Race>();
    protected List<Classe> Classes { get; set; } = new List<Classe>();
    public bool ValueClasseChanged { get; set; }
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
    public List<VoieChroniquesOublies> Voies { get; set; } = new List<VoieChroniquesOublies>();

    protected override async Task LoadAsync()
    {
        Task<List<Race>> taskRaces = GetScopedService<IRaceService>().GetRacesAsync(GameId, CancellationToken.None);
        Task<List<Classe>> taskClasses = GetScopedService<IClasseService>().GetClassesAsync(GameId, CancellationToken.None);
        Races = await taskRaces;
        Classes = await taskClasses;
    }

    protected async Task Save()
    {
        await FormBase.Validate();
        await Form.Validate();
        if (FormBase.IsValid && Form.IsValid)
        {
            if (GameId == Ids.Jeux.ChroniquesOublies)
            {
                await SaveChroniqueOublieAsync();
                Back();
            }
        }
    }
    protected async Task ApplySelectedCultureAsync()
    {
        Voies = new();
        await InvokeAsync(() =>
        {
            ValueClasseChanged = false;
            StateHasChanged();
        });
        Voies = await LoadVoieChroniquesOubliesAsync(ClasseSelected.Id, default);
        InvokeAsync(() =>
        {
            StateHasChanged();
        });
    }

    private async Task SaveChroniqueOublieAsync()
    {
        FichePersoChroniquesOublies.UserId = IdUserInterne;
        FichePersoChroniquesOublies.JeuId = GameId;
        FichePersoChroniquesOublies.PartieId = MyGameId;
        FichePersoChroniquesOublies.PvEnCours = FichePersoChroniquesOublies.PvMax;
        FichePersoChroniquesOublies.JoinFichePersoChroniquesOubliesClasses = new List<JoinFichePersoChroniquesOubliesClasse>()
        {
            new JoinFichePersoChroniquesOubliesClasse()
            {
                ClasseId = ClasseSelected.Id
            }
        };
        if (!FormBase.IsRaceCustom)
        {
            FichePersoChroniquesOublies.RaceLibelle = FichePersoChroniquesOublies.Race?.RaceLibelle;
            FichePersoChroniquesOublies.RaceId = FichePersoChroniquesOublies.Race?.Id;
            FichePersoChroniquesOublies.Race = null;
        }
        await GetScopedService<IJeuService>().AddFichePersoChroniquesOubliesAsync(FichePersoChroniquesOublies, CancellationToken.None);
    }

    protected void Back()
    {
        Navigation.NavigateTo(Routes.MyGamesDetailsTemplate.Replace("{GameId:guid}", GameId.ToString()).Replace("{MyGameId:guid}", MyGameId.ToString()), true);
    }
    protected void OnValueClasseChanged(Classe selected)
    {
        ClasseSelected = selected;
        InvokeAsync(() =>
        {
            IsReady = false;
            StateHasChanged();
        });
        Task.Run(() =>
        {
            Voies = LoadVoieChroniquesOubliesAsync(ClasseSelected.Id, CancellationToken.None).GetAwaiter().GetResult();
            InvokeAsync(() =>
            {
                IsReady = true;
                StateHasChanged();
            });
        });
        // Do other stuff
    }

    private async Task<List<VoieChroniquesOublies>> LoadVoieChroniquesOubliesAsync(Guid id, CancellationToken none)
    {
        Task<List<VoieChroniquesOublies>> taskVoies = GetScopedService<IClasseService>().GetVoieChroniquesOubliesForClassesAsync(id, none);
        List<VoieChroniquesOublies> voies = await taskVoies;
        return voies;
    }
}