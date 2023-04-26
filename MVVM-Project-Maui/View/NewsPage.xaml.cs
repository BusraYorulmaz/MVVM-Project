using MVVM_Project_Maui.ViewModel;

namespace MVVM_Project_Maui.View;

public partial class NewsPage : ContentPage
{
	public NewsPage()
	{
		InitializeComponent();
		BindingContext = new NewsViewModel();
	}
}