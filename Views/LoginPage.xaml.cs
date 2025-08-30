using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Version3OfERP21_8System.ViewModel;
using Version3OfERP21_8System.Views.Pages.RepresentativeAndCollector;
using Version3OfERP21_8System.Views.Windows;

namespace Version3OfERP21_8System.Views
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            //if (UsernameText.Text == "1" && PasswordText.Password == "1")
            if ( true)
            {
                var dashboard = new Views.Pages.Dashboard();
                MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(dashboard);

            }
        }
    }
}
