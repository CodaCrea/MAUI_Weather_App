using MauiAppWeather.Models;
using MauiAppWeather.Services;

namespace MauiAppWeather;

public partial class WeatherPage : ContentPage
{
    public List<Models.List> weatherList;

    public WeatherPage()
    {
        InitializeComponent();
        weatherList = new();
    }

    protected override async void OnAppearing()
    {
        double latitude = 45.188529;
        double longitude = 5.724524;

        base.OnAppearing();
        Root? result = await ApiServices.GetWeather(latitude, longitude);

        if (string.IsNullOrWhiteSpace(result?.ToString())) return;

        foreach (Models.List item in result.List)
        {
            weatherList.Add(item);
        }
        LblCity.Text = result.City.Name;
        LblDescription.Text = result.List[0].Weather[0].Description;
        LblTemperature.Text = $"{result.List[0].Main.Temperature} °C";
        LblHumidity.Text = $"{result.List[0].Main.Humidity} %";
        LblWind.Text = $"{result.List[0].Wind.Speed} km/h";
        ImgWeatherIcon.Source = result.List[0].Weather[0].CustomIcon;
        CvWeather.ItemsSource = weatherList;
    }
}