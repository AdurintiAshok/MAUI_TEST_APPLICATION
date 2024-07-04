using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using EmployeeData.Model.ViewModel;

namespace EmployeeData.Pages.ViewModels
{
    public partial class TaskInfoViewModel : ObservableObject  // Ensure this class is public
    {
        [ObservableProperty]
        private ObservableCollection<TaskResponse.ListData> tasks;

        public TaskInfoViewModel(ObservableCollection<TaskResponse.ListData> tasks)
        {
            Tasks = tasks;
        }
    }
}
