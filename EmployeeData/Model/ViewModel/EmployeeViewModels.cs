using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeData.Pages;
using System.Collections.ObjectModel;

namespace EmployeeData.Model.ViewModel
{
    internal partial class EmployeeViewModels : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Employee> employees = new();
        [ObservableProperty]
        private Employee employee = new Employee();

        [RelayCommand]
        public void AddEmployee()
        {
            Employees.Add(Employee);
            Employee = new Employee();
        }
    }
}
