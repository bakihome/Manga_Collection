using Microsoft.EntityFrameworkCore;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeebTracker.EntityFramework
{
    public class WeebTrackerDBContext : DbContext
    {
        public DbSet<Collectible> Collectibles { get; set; }

        public DbSet<Anime> Animes { get; set; }

        public DbSet<Manga> Manga { get; set; }

        public DbSet<EditionInfo> EditionInfos { get; set; }

        public DbSet<AnimeEditionInfo> AnimeEditionInfos { get; set; }

        public DbSet<MangaEditionInfo> MangaEditionInfos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WeebTrackerDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }       

    }
}
