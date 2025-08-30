using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.ViewModel.Commands.Login;

namespace Version3OfERP21_8System.ViewModel
{
    public class LoginViewModel : ObservableObject
    {
        public MainWindowViewModel mainWindowViewModel { get; set; }
        public string userNmae
        {
            get;
            set;
        }
        public string password { get; set; }

        public LoginCommand Login { get; set; }
        public LoginViewModel()
        {
            Login = new LoginCommand(this);
        }
    }
}
