using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.Views.Windows;

namespace Version3OfERP21_8System.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        public static MainWindow MainWindow { get; set; }


        public MainWindowViewModel()
        {

        }

        internal void setContext(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
        }
    }
}
