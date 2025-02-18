using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

namespace MellmothJdr
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            IServiceCollection services = builder.Services;
            AddServices(services, new Uri(builder.HostEnvironment.BaseAddress));

            await builder.Build().RunAsync();
        }

        private static void AddServices(IServiceCollection services, Uri baseAddress)
        {
            services.AddScoped(sp => new HttpClient { BaseAddress = baseAddress });
            services.AddMudServices();

        }
    }
}
