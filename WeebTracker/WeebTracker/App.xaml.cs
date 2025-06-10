using Microsoft.EntityFrameworkCore;
using Models;
using Models.DBModels;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Windows;
using System.Windows.Input;
using WeebTracker.EntityFramework;
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
            PrivateCollection currentCollection = new PrivateCollection();

            // Initiale Daten einfügen
            //using (var ctx = new WeebTrackerDBContext())
            //{
            //    currentCollection.GenerateData();
            //    foreach (Collectible col in currentCollection)
            //    {
            //        ctx.Collectibles.Add(col);
            //        ctx.SaveChanges();
            //    }
            //}
        }
    }
}
