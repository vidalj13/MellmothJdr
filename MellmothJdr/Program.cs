using MellmothJdr.Commun.Settings;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

using MudBlazor.Services;

using TransverseApiSessionCDR.Infrastructure;


var builder = WebApplication.CreateBuilder(args);
string dataConnectionStringKey = "Data";
IConfiguration Configuration = builder.Configuration;
IConfigurationSection globalSettingsSection = Configuration.GetSection(GlobalSettings.Section);
GlobalSettings globalSettings = globalSettingsSection.Get<GlobalSettings>();
string connectionString = Configuration.GetConnectionString(dataConnectionStringKey);

builder.Services
    .AddRazorPages().Services
    .AddServerSideBlazor().Services
    .AddServices(connectionString)
    .AddMudServices()
    .AddCascadingAuthenticationState()
    .AddAuthorizationCore()
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie().Services
        .AddAuthentication()
            .AddGoogle(options =>
            {
                options.ClientId = globalSettings.ClientIdGoogle;
                options.ClientSecret = globalSettings.ClientSecretGoolge;
                options.Scope.Add("email");
                options.ClaimActions.MapJsonKey("urn:google:image", "picture");
                options.SaveTokens = true;
            });

WebApplication app = builder.Build();

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

if (globalSettings.AutoMigrate)
{
    using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
    {
        MigrationContext context = new();
        context.Database.GetDbConnection().ConnectionString = connectionString;
        context.Database.Migrate();
    }
}

await app.RunAsync().ConfigureAwait(false);