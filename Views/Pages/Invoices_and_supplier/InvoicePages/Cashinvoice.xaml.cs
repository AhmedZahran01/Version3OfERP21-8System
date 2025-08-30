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
    /// <summary>
    /// Interaction logic for Cashinvoice.xaml
    /// </summary>
    public partial class Cashinvoice : Page
    {
        List<Suppliers> SupplierNames = new List<Suppliers>();
        List<CashInvoice> CashInvoiceData = new List<CashInvoice>();
        public Cashinvoice()
        {
            InitializeComponent();
            setDataInitial();
            cb_SuppliersName.ItemsSource = SupplierNames;
            cb_SuppliersName.SelectedIndex = 0; // اختيار أول عنصر

            dgCashInvoice.ItemsSource = CashInvoiceData;

        }
             
        public void setDataInitial()
        {
            SupplierNames = seedingClassesData.SeedsuppliersData().ToList();
            CashInvoiceData = seedingClassesData.SeedCashInvoiceData().ToList();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoicesRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);
        }
    }
}
