using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return JsonSerializer.Deserialize<WeatherForecast[]>
                (await _httpClient.GetStringAsync($"WeatherForecast"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
