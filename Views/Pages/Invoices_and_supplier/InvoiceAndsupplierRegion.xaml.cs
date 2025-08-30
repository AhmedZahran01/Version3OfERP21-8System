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
    /// Interaction logic for InvoiceAndsupplierRegion.xaml
    /// </summary>
    public partial class InvoiceAndsupplierRegion : Page
    {
        public InvoiceAndsupplierRegion()
        {
            InitializeComponent();
        }


        private void BtnInvoiceRegions_Click(object sender, RoutedEventArgs e)
        {
            var invoicesRegion = new InvoicesRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(invoicesRegion);

        }

        private void Suppliers_cash(object sender, RoutedEventArgs e)
        {
            var Suppliers_cashPage = new Suppliers_cashPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Suppliers_cashPage);

        }

        private void Supplier_accounts(object sender, RoutedEventArgs e)
        {
            var Supplier_accountsPage = new Supplier_accountsPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Supplier_accountsPage);

        }

        private void Stores(object sender, RoutedEventArgs e)
        {
            var StoresPage = new StoresPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(StoresPage);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new Version3OfERP21_8System.Views.Pages.Dashboard();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);
        }


    }
}
