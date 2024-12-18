using System;

enum Weather
{
    Sunny = 1,
    Rainy,
    Cloudy,
    Stormy
}

class WeatherForecast
{
    public string GetAdvice(Weather weather)
    {
        switch (weather)
        {
            case Weather.Sunny:
                return "It's sunny, wear sunglasses!";
            case Weather.Rainy:
                return "It's rainy, take an umbrella!";
            case Weather.Cloudy:
                return "It's cloudy, you might want a jacket.";
            case Weather.Stormy:
                return "It's stormy, stay indoors!";
            default:
                return "Weather information unavailable.";
        }
    }
}

class Program
{
    static void Main()
    {
        WeatherForecast forecast = new WeatherForecast();

        Weather currentWeather = Weather.Rainy;
        Console.WriteLine($"Current weather: {currentWeather}");
        Console.WriteLine(forecast.GetAdvice(currentWeather));
    }
}
