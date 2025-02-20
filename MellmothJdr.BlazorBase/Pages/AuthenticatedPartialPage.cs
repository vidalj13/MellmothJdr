using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace MellmothJdr.BlazorBase.Pages
{
    [Authorize]
    public abstract class AuthenticatedPartialPage : ComponentBase
    {
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        protected ClaimsPrincipal User { get; set; }
        protected bool IsAuthenticated { get; set; } = false;
        protected bool IsReady { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            IsReady = false;
            AuthenticationState authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            User = authState.User;

            if (!(User == null || !User.Identity.IsAuthenticated))
            {
                IsAuthenticated = true;
            }
            StateHasChanged();
            Load();
        }

        protected virtual void Load()
        {
            Task.Run(() =>
            {
                LoadAsync().GetAwaiter().GetResult();
                InvokeAsync(() =>
                {
                    IsReady = true;
                    StateHasChanged();
                });
            });
        }

        protected abstract Task LoadAsync();
    }
}