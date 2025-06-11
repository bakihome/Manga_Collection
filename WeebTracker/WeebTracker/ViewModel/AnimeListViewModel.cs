using Models.DBModels;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebTracker.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace WeebTracker.ViewModel
{
    public class AnimeListViewModel : BaseViewModel
    {
        public ObservableCollection<Collectible> Animes { get; set; }

        public AnimeListViewModel()
        {
            Animes = new ObservableCollection<Collectible>();
            LoadAnimes();
        }

        private void LoadAnimes()
        {
            PrivateCollection currentCollection;

            using (var ctx = new WeebTrackerDBContext())
            {
                List<Collectible> collectibles = ctx.Collectibles
                    .Include(c => c.EditionInfo)
                    .Where(c => c.Medium == "Anime")
                    .ToList();
                Animes = new ObservableCollection<Collectible>(collectibles);
            }
        }
    }
}
