using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;
namespace MellmothJdr.Pages.MesParties;

public class DetailPartieAddPersoPage : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    [Parameter]
    public Guid MyGameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid

    protected override async Task LoadAsync()
    {

    }
}