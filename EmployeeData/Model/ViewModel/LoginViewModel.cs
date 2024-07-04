using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeData.Services;
using Microsoft.Maui.Controls;
using EmployeeData.Pages;
using EmployeeData.Model.ViewModel;

namespace EmployeeData.Model.ViewModel
{
    internal partial class LoginViewModel : ObservableObject
    {
        private readonly LoginService _loginService;
        private readonly INavigation _navigation;

        public LoginViewModel(INavigation navigation)
        {
            _loginService = new LoginService();
            _navigation = navigation;
            IdTaskTypes = new ObservableCollection<TaskResponse.ListData>();
        }

        [ObservableProperty]
        private string userName;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private bool result;

        [ObservableProperty]
        private string sessionId;

        [ObservableProperty]
        private int idUser;

        [ObservableProperty]
        private ObservableCollection<TaskResponse.ListData> idTaskTypes;

        [RelayCommand]
        private async Task LoginUser()
        {
            var userInfo = await _loginService.LoginUser(UserName, Password);
            if (userInfo != null)
            {
                Result = userInfo.Result;
                IdUser = userInfo.IdUser;
                SessionId = userInfo.IdSession;
                await _navigation.PushAsync(new SessionPage(SessionId,IdUser));
            }
        }
        [RelayCommand]
        private async Task MoveUser()
        {
            await GetTasks();
            await _navigation.PushAsync(new TaskInfo(idTaskTypes));
        }
        [RelayCommand]
        private async Task GetTasks()
        {
            var taskInfo = await _loginService.GetTaskType(SessionId, IdUser);
            if (taskInfo != null)
            {
                IdTaskTypes.Clear();
                foreach (var taskType in taskInfo.List)
                {
                    IdTaskTypes.Add(taskType);
                }
                
            }
        }
    }
}
