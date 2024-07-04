using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData.Model.ViewModel
{
    internal partial class WeatherPageViewModel : ObservableObject
    {
        private readonly WeatheApiService weatheApiService;

       public WeatherPageViewModel()
        {
            weatheApiService = new WeatheApiService();
        }
        [ObservableProperty]
        private string lat;

        [ObservableProperty] 
        private string lng;

        [ObservableProperty]
        private double humidity;
        [ObservableProperty]
        private string location;

        [ObservableProperty]
        private double cloud;

        [ObservableProperty]
        private string isDay;

        [ObservableProperty]
        private string condition;

        [ObservableProperty]
        private string weatherIcon;

        [ObservableProperty]
        private double temp;

        [RelayCommand]
        private async Task Refresh() {
            var _weatherInfo = await weatheApiService.getWeatherData(Lat, Lng);
            Console.WriteLine(_weatherInfo.Current.windchill_f);
            if (_weatherInfo != null)
            {
                WeatherIcon = _weatherInfo.Current.condition.icon;
                Humidity = _weatherInfo.Current.humidity;
                Cloud = _weatherInfo.Current.cloud;
                Location = _weatherInfo.Location.name;
                Condition=_weatherInfo.Current.condition.text;
                Temp=_weatherInfo.Current.temp_c;
                if (_weatherInfo.Current.is_day == 1)
                {
                    IsDay = "Yes";
                }
                else
                {
                    IsDay = "No";
                }
            }
        }
    }
}
