using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EmployeeData.Model;
using EmployeeData.Model.ViewModel;
using Newtonsoft.Json;

namespace EmployeeData.Services
{
    internal class LoginService
    {
        private readonly HttpClient _httpClient;

        public LoginService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<LoginResponse> LoginUser(string username, string password)
        {
            var loginRequest = new
            {
                Username = username,
                Password = password
            };

            var json = JsonConvert.SerializeObject(loginRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(Constants.BASE_URL, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseString);
                return loginResponse;
            }
            else
            {
                throw new Exception("Failed to login");
            }
        }

        public async Task<TaskResponse> GetTaskType(string sessionId, int idUser)
        {
            var taskRequest = new
            {
                idSession = sessionId,
                idUser = idUser
            };

            var json = JsonConvert.SerializeObject(taskRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://applications.nec-oman.com:55100/api/GetUserTasks", content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Raw JSON Response: " + responseString); // Log the response

                var taskResponse = JsonConvert.DeserializeObject<TaskResponse>(responseString);
                return taskResponse;
            }
            else
            {
                throw new Exception("Failed to retrieve tasks");
            }
        }
    }
}
