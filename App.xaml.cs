using Dokaanah.DataAccessLayer.Data;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Data;
using System.Windows;
using Version3OfERP21_8System.Models.InvoiceContext;
using Version3OfERP21_8System.ViewModel;

namespace Version3OfERP21_8System
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                var host = Host.CreateDefaultBuilder()
                    .ConfigureServices((context, services) =>
                    {
                        // Add DbContext to DI
                        services.AddDbContext<InvoiceDbContext>(options =>
                            options.UseMySQL( 
                                  "server=localhost;database=invoiceSystem;uid=root;pwd=root;" ));


                        services.AddTransient<InvoiceDbContext>();
                    })
                    .Build();

                using var scope = host.Services.CreateScope();
                var services = scope.ServiceProvider;

                var dbContext = services.GetRequiredService<InvoiceDbContext>();
                dbContext.Database.Migrate(); // sync افضل هنا
                await StoreDokContextSeed.SeedAsync(dbContext);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // اعمل Logger مظبوط كده:
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                });
                var logger = loggerFactory.CreateLogger<App>();
                logger.LogError(ex, "An error occurred during migration or seeding.");
            }

            // افتح الـ MainWindow بعد كده
            var mainWindow = new Views.Windows.MainWindow();
            var mainWindowViewModel = new MainWindowViewModel();
            mainWindow.DataContext = mainWindowViewModel;
            mainWindowViewModel.setContext(mainWindow);

            var login = new Views.StartPageBeforeLogin();
            mainWindow.Frame.NavigationService.Navigate(login);

            mainWindow.Show();


            //Version3OfERP21_8System.Views.Windows.MainWindow mainWindow = new Views.Windows.MainWindow();
            //MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            //mainWindow.DataContext = mainWindowViewModel;
            //mainWindowViewModel.setContext(mainWindow);
            //var login = new Views.StartPageBeforeLogin();
            //mainWindow.Frame.NavigationService.Navigate(login);

            //new DoctorDBHandler();
            //new StaffDBHandler();
            //new StudentDBHandler();
            //new ManagerDBHandler();

            //mainWindow.Show();

        }

    }

}
 
