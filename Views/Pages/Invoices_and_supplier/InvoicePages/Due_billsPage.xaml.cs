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
using Version3OfERP21_8System.Models.Invoices_and_supplier;
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.ViewModel;
using Version3OfERP21_8System.HelperFunctions;

namespace Version3OfERP21_8System.Views.Pages.Invoices_and_supplier.InvoicePages
{ 
    public partial class Due_billsPage : Page
    {
        List<Suppliers> SupplierNames = new List<Suppliers>();
        List<Due_billsInvoice> due_billsInvoice = new List<Due_billsInvoice>();

        public Due_billsPage()
        {
            InitializeComponent();

            setDataInitial();
            cb_SuppliersName.ItemsSource = SupplierNames;
            cb_SuppliersName.SelectedIndex = 0; // اختيار أول عنصر

            dgDueInvoice.ItemsSource = due_billsInvoice;

        }

        public void setDataInitial()
        {
            SupplierNames = seedingClassesData.SeedsuppliersData().ToList();
            due_billsInvoice = seedingClassesData.SeedDue_billsInvoiceData().ToList();
        } 

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoicesRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);
        }
    }
}
