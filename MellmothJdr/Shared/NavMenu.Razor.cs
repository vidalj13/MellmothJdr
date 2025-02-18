using System.Security.Claims;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace MellmothJdr.Shared;

public class NavMenuComponent : ComponentBase
{
    [Inject]
    public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

    protected ClaimsPrincipal User;
    protected string Avatar;

    protected bool collapseNavMenu = true;

    protected string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    protected void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        User = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;



        var avatar = User.FindFirst("urn:google:image");
        Avatar = avatar != null ? avatar.Value : "";

    }
}