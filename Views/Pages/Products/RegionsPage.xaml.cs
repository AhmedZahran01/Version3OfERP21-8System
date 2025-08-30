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

namespace Version3OfERP21_8System.Views.Pages.Products
{
    /// <summary>
    /// Interaction logic for RegionsPage.xaml
    /// </summary>
    public partial class RegionsPage : Page
    {
        public RegionsPage()
        {
            InitializeComponent();
        }

        private void BtnMainRegions_Click(object sender, RoutedEventArgs e)
        {
            var mainRegionPage = new Version3OfERP21_8System.Views.Pages.Products.MainRegionPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(mainRegionPage);

        }

        private void BtnSubRegions_Click(object sender, RoutedEventArgs e)
        {
            var subRegionPage = new Version3OfERP21_8System.Views.Pages.Products.SubRegionPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(subRegionPage);

        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {
         
             
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new Version3OfERP21_8System.Views.Pages.Dashboard();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);

        }

    }
}
