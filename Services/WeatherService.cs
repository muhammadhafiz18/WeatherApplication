using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Services;

public class WeatherService(HttpClient httpClient) : IWeatherService
{
    private readonly HttpClient httpClient = httpClient;
    private readonly string apiKey = "a4f47604f64115571e6884eeb33456c8";

    public Task<WeatherResponse> GetWeatherAsync(string city)
    {
        throw new NotImplementedException();
    }
}
