using Microsoft.EntityFrameworkCore;
using Models;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
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
using System.Windows.Shapes;
using WeebTracker.EntityFramework;
using WeebTracker.ViewModel;

namespace WeebTracker.Views
{
    /// <summary>
    /// Interaction logic for StatisticWindow.xaml
    /// </summary>
    public partial class StatisticWindow : Window
    {
        public StatisticWindow()
        {
            InitializeComponent();
            PrivateCollection currentCollection;

            using (var ctx = new WeebTrackerDBContext())
            {
                List<Collectible> collectibles = ctx.Collectibles
                    .Include(c => c.EditionInfo)                    
                    .ToList();
                currentCollection = new PrivateCollection(collectibles);
            }
            
            int mangaseries = 0;
            int mangafinalised = 0;
            int mangavolumes = 0;
            double mangacost = 0;
            int animemovies = 0;
            int animeseries = 0;
            double animecost = 0;
            double totalcost = 0;
            foreach (Collectible col in currentCollection)
            {
                if (col.Medium == "Manga")
                {
                    mangaseries++;
                    if (col.Finalised)
                    {
                        mangafinalised++;
                    }
                }
                else
                {
                    if (col is Anime anime)
                    {
                        if (anime.Description == "Film")
                        {
                            animemovies++;
                        }
                        if (anime.Description == "Serie")
                        {
                            animeseries++;
                        }
                    }
                }


                if (col.EditionInfo.Count > 0)
                {
                    foreach (EditionInfo info in col.EditionInfo)
                    {
                        if (info is MangaEditionInfo)
                        {
                            mangavolumes++;
                            mangacost += info.Price;
                        }
                        if (info is AnimeEditionInfo)
                        {
                            animecost += info.Price;
                        }
                    }
                }
                totalcost = mangacost + animecost;
                DataContext = new StatisticsViewModel
                {
                    MangaCount = mangaseries,
                    MangaCompleted = mangafinalised,
                    MangaVolumes = mangavolumes,
                    MangaCost = $"{mangacost:N2} €",
                    AnimeMovies = animemovies,
                    AnimeSeries = animeseries,
                    DvdCost = $"{animecost:N2} €",
                    TotalCost = $"{totalcost:N2} €"
                };                
            }            
        }
        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
