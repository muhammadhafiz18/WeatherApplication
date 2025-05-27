namespace WeatherApp.Models;

public class WeatherResponse
{
    public MainInfo? Main { get; set; }
    public List<WeatherInfo>? Weather { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Temperature in {Name}: {Main.Temp - 273} C";
    }
}