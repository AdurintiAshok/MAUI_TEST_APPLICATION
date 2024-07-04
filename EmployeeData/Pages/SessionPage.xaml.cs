using EmployeeData.Model.ViewModel;
using EmployeeData.Services;

namespace EmployeeData.Pages;

public partial class SessionPage : ContentPage
{

	public SessionPage(string usersession,int userid)
	{
		InitializeComponent();
        var viewModel = new LoginViewModel(Navigation)
        {
            SessionId = usersession,
            IdUser=userid

        };
        BindingContext = viewModel;
    }
}