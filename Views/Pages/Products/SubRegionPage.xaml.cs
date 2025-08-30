using Microsoft.EntityFrameworkCore;
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
using Version3OfERP21_8System.Models.InvoiceContext;
using Version3OfERP21_8System.ViewModel;

namespace Version3OfERP21_8System.Views.Pages.Products
{
    /// <summary>
    /// Interaction logic for SubRegionPage.xaml
    /// </summary>
    public partial class SubRegionPage : Page
    {
        ObservableCollection<SubRegion> observalSubRegion = new ObservableCollection<SubRegion>();
        ObservableCollection<MainRegions> observalMainRegions = new ObservableCollection<MainRegions>();

        List<string> mainRegionNameslist = new List<string>();
        InvoiceDbContext dbContext = new InvoiceDbContext();
        public SubRegionPage()
        {
            InitializeComponent();
            //SeedDefaultRegions();
            SeedSubRegions();
            cb_MainRegionName.ItemsSource = returnListOfNamesByObserv();
            cb_MainRegionName.SelectedIndex = 0; // اختيار أول عنصر
            dgSubRegions.ItemsSource = observalSubRegion;

        }

        private List<string> returnListOfNamesByObserv()
        {
            List<MainRegions> defaults = dbContext.MainRegions.ToList();
            foreach (var region in defaults)
            {
                observalMainRegions.Add(region);
            }
            foreach (var item in observalMainRegions)
            {
                mainRegionNameslist.Add(item.MainRegionName);
            }

            return mainRegionNameslist;
        }
        private void SeedSubRegions()
        {
            //List<SubRegion> subRegions = seedingClassesData.SeedSubRegionData();
            List<SubRegion> subRegions = dbContext.SubRegions.Include(s => s.mainRegions).ToList();

            foreach (var subregion in subRegions)
            { 
                 observalSubRegion.Add(subregion); 
            }

        }

        //private void SeedDefaultRegions()
        //{
        //    var defaults = seedingClassesData.SeedMainRegions();

        //    foreach (var region in defaults)
        //        observalMainRegions.Add(region);
        //}

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var regionsPage = new Version3OfERP21_8System.Views.Pages.Products.RegionsPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(regionsPage);

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgSubRegions.SelectedItem is SubRegion SubRegion)
            {
                observalSubRegion.Remove(SubRegion);
                MessageBox.Show("تم الحذف");
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف قبل الحذف");
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string regionName = cb_MainRegionName.Text;
            string subRegionName = txtSbuRegionStartNumber.Text;
            int lastId = dbContext.MainRegions.OrderBy(i => i.Id).LastOrDefault()?.Id ?? 0;
            int mainId = dbContext.MainRegions.Where(p => p.MainRegionName == regionName)
                                    .Select(i => i.Id).FirstOrDefault();
            if (!string.IsNullOrEmpty(regionName) && !string.IsNullOrEmpty(subRegionName))
            {
                SubRegion InputMainRegions = new SubRegion()
                {
                    Id = lastId + 1,
                    MainRegionName = regionName,
                    subRegionName = subRegionName,
                    mainRegionsId = mainId
                };

                observalSubRegion.Add(InputMainRegions);
                dbContext.SubRegions.Add(InputMainRegions);
                dbContext.SaveChanges();
                MessageBox.Show("تم الإضافة");
            }
            else
            {
                MessageBox.Show("من فضلك ادخل بيانات صحيحة");
            }
        }

        private void dgSubRegions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgSubRegions.SelectedItem is SubRegion SubRegion)
            {

                btnsvisabiltiy.Visibility = Visibility.Visible;
                //btnDelete.Visibility = Visibility.Visible;

                ////dbContext.SubRegions.Remove(SubRegion);
                //dbContext.SaveChanges();
                //MessageBox.Show("تم الحذف");
                //observalSubRegion.Remove(SubRegion);
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف قبل الحذف");
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
