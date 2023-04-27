using MVVM_Project_Maui.ViewModel;

namespace MVVM_Project_Maui.View;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
		BindingContext = new DetailViewModel();

    }
}