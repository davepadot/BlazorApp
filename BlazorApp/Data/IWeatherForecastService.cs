using System;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}