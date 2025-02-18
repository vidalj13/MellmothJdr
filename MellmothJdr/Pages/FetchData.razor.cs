using MellmothJdr.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace MellmothJdr.Pages;

public class FetchDataPage : AuthenticatedPage
{
    [Inject]
    public WeatherForecastService ForecastService { get; set; }

    protected WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
    }
}