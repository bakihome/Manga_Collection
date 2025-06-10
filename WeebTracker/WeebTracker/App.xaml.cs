using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data;
using System.Windows;
using WeebTracker.ViewModel;

namespace WeebTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Init view and viewmodel
            MainWindow mainWindow = new MainWindow();
            MainWindowViewModel mainViewModel = new MainWindowViewModel();
            mainWindow.DataContext = mainViewModel;

            // Show Window
            mainWindow.Show();
        }
    }
}
