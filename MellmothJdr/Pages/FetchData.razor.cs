using MellmothJdr.Services.Dto;
using MellmothJdr.Services.IServices;

using Microsoft.AspNetCore.Components;

namespace MellmothJdr.Pages;

public class FetchDataPage : AuthenticatedPage
{
    [Inject]
    public IWeatherForecastService ForecastService { get; set; }

    protected WeatherForecastDto[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
    }
}