using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Commun.Constantes;
using MellmothJdr.DAL.Entities;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies;
using MellmothJdr.DAL.Entities.FichesPersos.ChroniquesOublies.Jointures;
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
   
}