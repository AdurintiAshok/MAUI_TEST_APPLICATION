using EmployeeData.Model.ViewModel;

namespace EmployeeData;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
		BindingContext = new WeatherPageViewModel();
		
	}
}