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

namespace Version3OfERP21_8System.Views.Pages.Invoices_and_supplier
{ 
    public partial class Suppliers_cashPage : Page
    {
        List<Suppliers> SupplierNames = new List<Suppliers>();
        List<Suppliers_cash> _suppliers_cash = new List<Suppliers_cash>();
        public Suppliers_cashPage()
        {
            InitializeComponent();
            setDataInitial();
            cb_Supplly_Name.ItemsSource = SupplierNames;
            cb_Supplly_Name.SelectedIndex = 0; // اختيار أول عنصر

            DataGridOfSupplyCash.ItemsSource = _suppliers_cash; 
        }


        public void setDataInitial()
        {
            SupplierNames = seedingClassesData.SeedsuppliersData().ToList();
            _suppliers_cash = seedingClassesData.SeedSuppliers_cashData().ToList();

        }


        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoiceAndsupplierRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);
        }

    }
}
