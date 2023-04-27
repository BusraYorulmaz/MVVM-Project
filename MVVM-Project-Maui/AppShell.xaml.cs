using MVVM_Project_Maui.View;

namespace MVVM_Project_Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailPage),typeof(DetailPage));
        }
    }
}