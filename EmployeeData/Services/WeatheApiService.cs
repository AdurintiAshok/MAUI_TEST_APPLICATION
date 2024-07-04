using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using EmployeeData.Model;
using EmployeeData.Model.ViewModel;
using Microsoft.Maui.Controls;
namespace EmployeeData.Services
{
    internal class WeatheApiService
    {
        private readonly HttpClient _httpClient;
        public WeatheApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.BASE_URL);
        }
        public async Task<WeatherApiResponse> getWeatherData(string lat,string longitud)
        {
            Console.WriteLine(lat);
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;
            string requestUri = $"v1/current.json?q={lat},{longitud}&key={Constants.API_KEY}";
            return await _httpClient.GetFromJsonAsync<WeatherApiResponse>(requestUri);
        }
    }
}
