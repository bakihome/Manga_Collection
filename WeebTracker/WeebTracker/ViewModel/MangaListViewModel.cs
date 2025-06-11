using Microsoft.EntityFrameworkCore;
using Models;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeebTracker.EntityFramework;

namespace WeebTracker.ViewModel
{
    public class MangaListViewModel :BaseViewModel
    {
        public ObservableCollection<Collectible> Mangas { get; set; }

        public MangaListViewModel() 
        {            
            Mangas = new ObservableCollection<Collectible>();
            LoadMangas();
        }

        private void LoadMangas()
        {
            PrivateCollection currentCollection;

            using (var ctx = new WeebTrackerDBContext())
            {
                List<Collectible> collectibles = ctx.Collectibles                    
                    .Include(c => c.EditionInfo)
                    .Where(c => c.Medium == "Manga")
                    .ToList();
                Mangas = new ObservableCollection<Collectible>(collectibles);
            }
        }

    }
}
