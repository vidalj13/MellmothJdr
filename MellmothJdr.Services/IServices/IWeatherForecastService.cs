using MellmothJdr.Services.Dto;

namespace MellmothJdr.Services.IServices
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecastDto[]> GetForecastAsync(DateOnly startDate);
    }
}