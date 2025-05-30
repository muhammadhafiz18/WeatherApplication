namespace WeatherApp.Models;

public class WeatherResponse
{
    public MainInfo? Main { get; set; }
    public List<WeatherInfo>? Weather { get; set; }
    public string? Name { get; set; }
    public int Visibility { get; set; }
    public WindInfo Wind { get; set; }
    public SysInfo Sys { get; set; }

    public override string ToString()
    {
        return $"Temperature in {Name}: {Main.Temp - 273} C\nCountry {Sys.Country}\nSunrise: {Sys.Sunrise}\nSunset: {Sys.Sunset}\nVisibility: {Visibility}\nSpeed: {Wind.Speed}\nDeg: {Wind.Deg}";
    }
}

public class WindInfo
{
    public double Speed { get; set; }
    public int Deg { get; set; }
}