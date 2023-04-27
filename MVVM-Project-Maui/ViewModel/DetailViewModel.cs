using CommunityToolkit.Mvvm.ComponentModel;
using MVVM_Project_Maui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Project_Maui.ViewModel
{
    [QueryProperty(nameof(User),"UserKey")]
    public partial class DetailViewModel:ObservableObject
    {
        public DetailViewModel() { }

        [ObservableProperty]
        User user;
    }
}
