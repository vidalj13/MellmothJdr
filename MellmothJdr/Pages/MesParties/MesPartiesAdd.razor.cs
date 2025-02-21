using MellmothJdr.BlazorBase.Pages;
using MellmothJdr.Commun.Constantes;
using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;

using MudBlazor;

using NotificationManager.Infrastructure.Entities;
namespace MellmothJdr.Pages.MesParties;

public class MesPartiesAddPage : AuthenticatedPage
{
    [Parameter]
    public Guid GameId { get; set; }  // Liaison du paramètre 'id' en tant que Guid
    protected bool success;
    protected MudForm form;
    protected Partie contextForm;
    protected override async Task LoadAsync()
    {
        await Task.Run(() =>
        {
            contextForm = new();
        });
    }
    protected async Task Save() {
        await form.Validate();
        if (form.IsValid)
        {
            contextForm.UserId = IdUserInterne;
            contextForm.JeuId = GameId;
            await GetScopedService<IJeuService>().AddPartiesAsync(contextForm, CancellationToken.None);
            Back();
        }
    }

    protected void Back()
    {
        Navigation.NavigateTo(Routes.MesGamesTemplate.Replace("{GameId:guid}", GameId.ToString()), true);
    }
}