using Microsoft.Maui.Controls;
using EmployeeData.Model.ViewModel;
using EmployeeData.Services;

namespace EmployeeData.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}
