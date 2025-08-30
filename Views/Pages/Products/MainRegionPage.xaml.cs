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
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Version3OfERP21_8System.Views.Pages.Products
{
    /// <summary>
    /// Interaction logic for MainRegionPage.xaml
    /// </summary>
    public partial class MainRegionPage : Page
    {
        ObservableCollection<MainRegions> observalMainRegions = new();
        List<MainRegions> mainRegions = new List<MainRegions>();

        public MainRegionPage()
        {
            InitializeComponent();
            SeedDefaultRegions();
            dgMainRegions.ItemsSource = observalMainRegions;
        }

        private void SeedDefaultRegions()
        {
            var defaults = seedingClassesData.SeedMainRegions();
            foreach (var region in defaults)
                observalMainRegions.Add(region);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegionName.Text) ||
                !int.TryParse(txtRegionStartNumber.Text, out int startNumber))
            {
                MessageBox.Show("من فضلك ادخل بيانات صحيحة");
                return;
            }
            int nextId = (observalMainRegions.LastOrDefault()?.Id ?? 0) + 1;

            observalMainRegions.Add(new MainRegions
            {
                Id = nextId,
                MainRegionName = txtRegionName.Text.Trim(),
                start_Number = startNumber
            });
            MessageBox.Show("  تم اضافه المنطقه الاساسية ");

            txtRegionName.Clear();
            txtRegionStartNumber.Clear();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (dgMainRegions.SelectedItem is not MainRegions selected)
            {
                MessageBox.Show("من فضلك اختر صف قبل الحذف");
                return;
            }
            observalMainRegions.Remove(selected);
            MessageBox.Show(" تم حذف المنطقه الاساسية ");
        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var regionsPage = new Version3OfERP21_8System.Views.Pages.Products.RegionsPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(regionsPage);

        }


        private void SearchByItemFullNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = SearchByItemTextBox.Text.ToLower();

            mainRegions = observalMainRegions.ToList();


            var suggestions = mainRegions.Select(i => i.MainRegionName).
                Where(i => i.ToLower().Contains(query));
            //Search(i => i.ItemFullName.ToLower().Contains(query));

            if (suggestions.Any())
            {
                SuggestionsItemsListBox.ItemsSource = suggestions;
                SuggestionsPopup.IsOpen = true;
            }
            else
            {
                SuggestionsPopup.IsOpen = false;
            }
        }

        private void SuggestionsItemsListBoxForText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SuggestionsItemsListBox.SelectedItem != null)
            {
                string fullname = (string)SuggestionsItemsListBox.SelectedItem;

                SearchByItemTextBox.Text = fullname;
                SuggestionsPopup.IsOpen = false;

                //Item selectedItem = MainVM.ItemVM.GetItemByFullName(fullname);
                var selectedItem = mainRegions.Select(i => i.MainRegionName == fullname).FirstOrDefault()!;




            }
        }


    }
}
