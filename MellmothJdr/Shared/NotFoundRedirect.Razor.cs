using System.Security.Claims;

using MellmothJdr.Commun.Constantes;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
namespace MellmothJdr.Shared;

public class NotFoundRedirectComponent : ComponentBase
{
    [Inject]
    public NavigationManager Navigation { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var currentUri = Navigation.Uri;
        var baseUri = Navigation.BaseUri[..1] + Routes.Home;

        // ✅ Redirection uniquement si ce n'est pas déjà /home
        if (!currentUri.Equals(baseUri, StringComparison.OrdinalIgnoreCase))
        {
            Navigation.NavigateTo(Routes.Home, true);
        }

    }
}