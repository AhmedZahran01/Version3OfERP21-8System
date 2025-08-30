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
using Version3OfERP21_8System.Views.Windows;

namespace Version3OfERP21_8System.Views.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 
            var regionsPage = new Version3OfERP21_8System.Views.Pages.Products.RegionsPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(regionsPage);
        }
          
        private void Products_Click_1(object sender, RoutedEventArgs e)
        {
            var productsPage = new Version3OfERP21_8System.Views.Pages.Products.productsPages();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(productsPage);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RepresentativeCollector_Click(object sender, RoutedEventArgs e)
        {
            var RepresentativeCollectorPage = new RepresentativeAndCollector.RepresentativeAndCollectorPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(RepresentativeCollectorPage);

        }

        private void invoice_Click_1(object sender, RoutedEventArgs e)
        {
            var invoicePage = new Invoices_and_supplier.InvoiceAndsupplierRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(invoicePage);
        }
    }
}
