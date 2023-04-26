using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Project_Maui.ViewModel
{
    public class NewsViewModel :INotifyPropertyChanged
    { 
        public Command SignInCommand { get; set; }
        private string userName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string UserName
        {
            get { return userName; }
            set { 
                userName = value;
                OnPropertyChanged("UserName");
            }
        }


        public NewsViewModel()
        {
            SignInCommand =  new Command(SignIn);
        }

        private void SignIn(object obj)
        {
            var user = UserName; 
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
