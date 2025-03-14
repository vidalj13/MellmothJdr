using MellmothJdr.Commun.Constantes;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MellmothJdr.Pages.Identity;

public class Logout(ILogger<Logout> logger) : PageModel
{
    public async Task<IActionResult> OnGetAsync(string? returnUrl = null)
    {
        returnUrl ??= Url.Content(Routes.Home);

        try
        {
            await HttpContext
                .SignOutAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to logout");
            var error = ex.Message;
        }

        return LocalRedirect(returnUrl);
    }
}