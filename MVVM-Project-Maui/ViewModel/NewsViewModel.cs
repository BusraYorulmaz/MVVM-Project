using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM_Project_Maui.Model;
using MVVM_Project_Maui.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace MVVM_Project_Maui.ViewModel
{
    public partial class NewsViewModel : ObservableObject
    {
        
        string username;
        public string Username
        {
            get { return username; }
            set
            {
               SetProperty(ref username, value);
            }
        }

        [ObservableProperty]
        string useremail;

        [ObservableProperty]
        string userphone;

        [RelayCommand]
        void Login()
        {
            var user = new User()
            {
                Name = Username,
                Email = this.useremail,
                Phone = this.userphone

                //Id = 1,
                //Name = "Busra",
                //Email = "by@gmail.com",
                //Phone = "05419254182"
            };

            //Shell Based Approach for Navigation
            Shell.Current.GoToAsync($"{nameof(DetailPage)}",
                new Dictionary<string, object>
                {
                    {"UserKey",user }
                });
   
            ////Legency way for Navigation
            //Shell.Current.Navigation.PushAsync(new DetailPage());
        }


        //INotifyPropertyChanged -> kullanıldığında kodlar aşağıdaki gibi olmalıdır.
        //public Command SignInCommand { get; set; }
        //private string userName;

        //public event PropertyChangedEventHandler PropertyChanged;

        //public string UserName
        //{
        //    get { return userName; }
        //    set { 
        //        userName = value;
        //        OnPropertyChanged("UserName");
        //    }
        //}

        //public NewsViewModel()
        //{
        //    SignInCommand =  new Command(SignIn);
        //}

        //private void SignIn(object obj)
        //{
        //    var user = UserName; 
        //}

        //void OnPropertyChanged(string name)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
    }
}
