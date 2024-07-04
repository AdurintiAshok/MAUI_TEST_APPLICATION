using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using EmployeeData.Model.ViewModel;

namespace EmployeeData.Pages
{
    public partial class TaskInfo : ContentPage
    {
        public ObservableCollection<TaskResponse.ListData> Tasks { get; set; }

        public TaskInfo(ObservableCollection<TaskResponse.ListData> tasks)
        {
            InitializeComponent();
            Console.WriteLine(tasks.ToString());
            Tasks = tasks;
            BindingContext = this;
        }
    }
}
