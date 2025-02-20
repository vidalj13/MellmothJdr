using System.Security.Claims;

using MellmothJdr.Commun.Constantes;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MellmothJdr.Pages.Identity;

[AllowAnonymous]
public class Login : PageModel
{
    public Login(IUsersService usersService) : base()
    {
        _usersService = usersService;
    }
    private IUsersService _usersService { get; set; }
    public IActionResult OnGetAsync(string? returnUrl = null)
    {
        return new ChallengeResult("Google", new()
        {
            RedirectUri = Url.Page("./Login",
                "Callback",
                new { returnUrl })
        });
    }

    public async Task<IActionResult> OnGetCallbackAsync(string? returnUrl = null, string? remoteError = null)
    {
        // Get the information about the user from the external login provider
        var user = User.Identities.FirstOrDefault();
        if (!(user?.IsAuthenticated ?? false))
            return LocalRedirect(Routes.Home);
        string email = user.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").Value;
        Guid userId = await _usersService.AddUserIfNotExistsAsync(new NotificationManager.Infrastructure.Entities.User()
        {
            ExterneId = email
        });

        AuthenticationProperties properties = new()
        {
            IsPersistent = true,
            RedirectUri = Request.Host.Value,
        };
        user.AddClaim(new Claim("IdUserInterne", userId.ToString()));
        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new(user),
            properties);

        return LocalRedirect(Routes.Home);
    }
}