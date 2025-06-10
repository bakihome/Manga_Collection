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
        DbSet<Collectible> Collectibles { get; set; }

        DbSet<Anime> Animes { get; set; }

        DbSet<Manga> Manga { get; set; }

        DbSet<EditionInfo> EditionInfos { get; set; }

        DbSet<AnimeEditionInfo> AnimeEditionInfos { get; set; }

        DbSet<MangaEditionInfo> MangaEditionInfos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WeebTrackerDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
