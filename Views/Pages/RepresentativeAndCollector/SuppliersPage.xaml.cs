using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Version3OfERP21_8System.HelperFunctions;
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.ViewModel;

namespace Version3OfERP21_8System.Views.Pages.RepresentativeAndCollector
{
    /// <summary>
    /// Interaction logic for SuppliersPage.xaml
    /// </summary>
    public partial class SuppliersPage : Page
    {
        ObservableCollection<Suppliers> observalCollectorRegions = new();
        public SuppliersPage()
        {
            InitializeComponent();
            SeedDefaultRegions();
            dgCollectors.ItemsSource = observalCollectorRegions;
        }


        private void SeedDefaultRegions()
        {
            var suppliers = seedingClassesData.SeedsuppliersData();

            foreach (var supplier in suppliers)
                observalCollectorRegions.Add(supplier);
        }


        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new RepresentativeAndCollectorPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);

        }
    }
}
