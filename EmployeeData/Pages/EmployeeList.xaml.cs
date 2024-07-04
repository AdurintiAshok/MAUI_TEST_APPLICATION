namespace EmployeeData.Pages;
using EmployeeData.Model;
using EmployeeData.Model.ViewModel;

public partial class EmployeeList : ContentPage
{
    public EmployeeList()
    {
        InitializeComponent();
        BindingContext = new EmployeeViewModels();
    }

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var employee = (Employee)e.Item;
        var employeeViewModel = new EmployeeViewModels { Employee = employee };
        var employeeDetailsPage = new EmployeeDetailsPage
        {
            BindingContext = employeeViewModel
        };
        Navigation.PushAsync(employeeDetailsPage);
    }
}
