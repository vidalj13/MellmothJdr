using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace MellmothJdr.BlazorBase.Pages
{
    [Authorize]
    public class AuthenticatedPage : ComponentBase
    {
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        protected Guid? IdUserInterne;
        protected override async Task OnInitializedAsync()
        {
            AuthenticationState authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            System.Security.Claims.ClaimsPrincipal user = authState.User;

            if (user == null || !user.Identity.IsAuthenticated)
            {
                Navigation.NavigateTo("Identity/Login", true);
            }
            var claim = user.FindFirst("IdUserInterne");
            IdUserInterne = Guid.Parse(claim?.Value);
        }
    }
}