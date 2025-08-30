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
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.ViewModel;

namespace Version3OfERP21_8System.Views.Pages.RepresentativeAndCollector
{
    /// <summary>
    /// Interaction logic for RepresentativeAndCollectorPage.xaml
    /// </summary>
    public partial class RepresentativeAndCollectorPage : Page
    {
        public RepresentativeAndCollectorPage()
        {
            InitializeComponent();
        }

        private void BtnCollector_Click(object sender, RoutedEventArgs e)
        {
            var collectorPage = new CollectorPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(collectorPage);

        }

        private void BtnRepresentative_Click(object sender, RoutedEventArgs e)
        {
            var representativePage = new RepresentativePage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(representativePage);

        }

        private void BtnStorekeepers_Click(object sender, RoutedEventArgs e)
        {
            var storekeepersPage = new StorekeepersPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(storekeepersPage);
        }

        private void BtnSuppliers_Click(object sender, RoutedEventArgs e)
        {
            var suppliersPage = new SuppliersPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(suppliersPage);

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new Version3OfERP21_8System.Views.Pages.Dashboard();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);

        }
    }
}
