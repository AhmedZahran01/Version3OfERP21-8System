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

namespace Version3OfERP21_8System.Views.Pages.Products
{ 
    public partial class productsPages : Page
    {
        ObservableCollection<Product> observProductsList = new ObservableCollection<Product>();
        List<string> productNames = new List<string>();
        public productsPages()
        {
            InitializeComponent();
            Seedproducts();
            cb_type.ItemsSource = productNames;
            cb_type.SelectedIndex = 0; // اختيار أول عنصر

            DataGrid.ItemsSource = observProductsList;
        }

        private void Seedproducts()
        {
            foreach (var product in seedingClassesData.SeedproductsData())
            {
                observProductsList.Add(product);
            }

            productNames = seedingClassesData.SeedproductNamesData();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            if (
                string.IsNullOrWhiteSpace(ProductName.Text) ||
               !int.TryParse(RepresentivePercentage.Text, out int startNumber) ||
               !int.TryParse(mainPrice.Text, out int mainPrice2) ||
               !int.TryParse(subValuePrice.Text, out int subValuePrice2))
            {
                MessageBox.Show("من فضلك ادخل بيانات صحيحة");
                return;
            }

            string percent = RepresentivePercentage.Text;
            string scbPri = subValuePrice.Text;
            string mainPri = mainPrice.Text;
            int lastId = observProductsList.LastOrDefault()?.Id ?? 0;
            Product InputProduct = new Product()
            {
                Id = lastId + 1,
                Name = ProductName.Text,
                Main_purchase_price = double.TryParse(mainPri, out double mainP) ? mainP : 0,
                Percentage_Representative = double.TryParse(percent, out double p) ? p : 0,
                Sale_purchase_price = double.TryParse(scbPri, out double subp) ? subp : 0,
                Type = cb_type.SelectedItem?.ToString(),
            };
            observProductsList.Add(InputProduct);

        }

        private void DeleteButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem is Product Product)
            {
                observProductsList.Remove(Product);
                MessageBox.Show("تم الحذف");
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف قبل الحذف");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new Version3OfERP21_8System.Views.Pages.Dashboard();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);

        }
    }
}
