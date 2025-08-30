﻿using System;
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
using Version3OfERP21_8System.Views.Pages.Invoices_and_supplier;

namespace Version3OfERP21_8System.Views.Pages.Invoices_and_supplier
{
    /// <summary>
    /// Interaction logic for InvoicesRegion.xaml
    /// </summary>
    public partial class InvoicesRegion : Page
    {
        public InvoicesRegion()
        {
            InitializeComponent();
        }

        private void Cashinvoice_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoicePages.Cashinvoice();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);

        }

        private void Dueinvoice_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoicePages.Due_billsPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);

        } 

        private void Return_to_supplier_Click(object sender, RoutedEventArgs e)
        {
            var Return_to_supplierPage = new InvoicePages.Return_to_supplierPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Return_to_supplierPage);

        }

        private void ruin_Click(object sender, RoutedEventArgs e)
        {
            var ruinPage = new InvoicePages.ruinPage();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(ruinPage);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new InvoiceAndsupplierRegion();
            MainWindowViewModel.MainWindow.Frame.NavigationService.Navigate(Dashboard);
        }

    }
}
