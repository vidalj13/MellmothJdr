using System.Security.Claims;

using MellmothJdr.Commun.Constantes;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace MellmothJdr.BlazorBase.Pages
{
    [Authorize]
    public class AuthenticatedPage : AuthenticatedPartialPage
    {
        protected Guid IdUserInterne;
        [Inject]
        protected IServiceScopeFactory _scopeFactory { get; set; }

        protected override Task LoadAsync()
        {
            return Task.CompletedTask;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (!IsAuthenticated)
            {
                Navigation.NavigateTo(Routes.Login, true);
            }
            Claim claim = User.FindFirst("IdUserInterne");
            IdUserInterne = Guid.Parse(claim?.Value);
        }

        protected T GetScopedService<T>() where T: IScopableService
        {
            return _scopeFactory.CreateScope().ServiceProvider.GetService<T>();
        }
    }
}