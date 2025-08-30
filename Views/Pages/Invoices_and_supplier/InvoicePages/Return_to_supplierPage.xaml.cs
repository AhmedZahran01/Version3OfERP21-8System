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
using Version3OfERP21_8System.HelperFunctions;
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.Models.Invoices_and_supplier;
using Version3OfERP21_8System.ViewModel;

namespace Version3OfERP21_8System.Views.Pages.Invoices_and_supplier.InvoicePages
{ 
    public partial class Return_to_supplierPage : Page
    {
        List<Suppliers> SupplierNames = new List<Suppliers>();
        List<Return_to_Supplier> Return_to_supplier = new List<Return_to_Supplier>();

        public Return_to_supplierPage()
        {
            InitializeComponent();
            setDataInitial();
            cb_SuppliersName.ItemsSource = SupplierNames;
            cb_SuppliersName.SelectedIndex = 0; // اختيار أول عنصر

            dgReturn_to_Supplier.ItemsSource = Return_to_supplier;
        }


        public void setDataInitial()
        {
            SupplierNames = seedingClassesData.SeedsuppliersData().ToList();
            Return_to_supplier = seedingClassesData.SeedReturn_to_SupplierData().ToList();

        }


        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoicesRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);
        }
    }
}
