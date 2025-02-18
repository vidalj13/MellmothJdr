using MellmothJdr;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using MudBlazor.Services;
using MellmothJdr.Services.Services;
using MellmothJdr.Services.IServices;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorPages().Services
    .AddServerSideBlazor().Services
    .AddScoped<IWeatherForecastService, WeatherForecastService>()
    .AddMudServices()
    .AddCascadingAuthenticationState()
    .AddAuthorizationCore()
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie().Services
        .AddAuthentication()
            .AddGoogle(options =>
            {
                options.ClientId = "18269906175-ca1ocgh56uf49evqh9im1cbv55p3uci0.apps.googleusercontent.com";
                options.ClientSecret = "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";
                options.Scope.Add("email");
                options.ClaimActions.MapJsonKey("urn:google:image", "picture");    
                options.SaveTokens = true;
            });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseExceptionHandler("/Error")
        .UseHsts();

app.UseHttpsRedirection()
    .UseStaticFiles()
    .UseCookiePolicy()
    .UseAuthentication()
    .UseRouting();
    
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

await app.RunAsync().ConfigureAwait(false);