using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace MellmothJdr.BlazorBase.Pages
{
    [Authorize]
    public class AuthenticatedPartialPage : ComponentBase
    {
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        protected ClaimsPrincipal User { get; set; }
        protected bool IsAuthenticated { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            AuthenticationState authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            User = authState.User;

            if (!(User == null || !User.Identity.IsAuthenticated))
            {
                IsAuthenticated = true;
            }
        }
    }
}