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

namespace Version3OfERP21_8System.Views.Pages.Invoices_and_supplier
{
    /// <summary>
    /// Interaction logic for StoresPage.xaml
    /// </summary>
    public partial class StoresPage : Page
    {
        public StoresPage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoiceAndsupplierRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);
        }
    }
}
