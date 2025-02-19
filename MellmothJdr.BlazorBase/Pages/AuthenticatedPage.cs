using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;

namespace MellmothJdr.BlazorBase.Pages
{
    [Authorize]
    public class AuthenticatedPage : AuthenticatedPartialPage
    {
        protected Guid? IdUserInterne;
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (!IsAuthenticated)
            {
                Navigation.NavigateTo("Identity/Login", true);
            }
            Claim claim = User.FindFirst("IdUserInterne");
            IdUserInterne = Guid.Parse(claim?.Value);
        }
    }
}