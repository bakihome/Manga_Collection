using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PrivateCollection : IEnumerable<Collectible>    
    {
        
        public List<Collectible> MainCollection = new List<Collectible>();  
        public IEnumerator<Collectible> GetEnumerator()
        {
            return MainCollection.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return MainCollection.GetEnumerator();
        }

        public PrivateCollection() {}

        public PrivateCollection(List<Collectible> dbcollection)
        {
            MainCollection = dbcollection;
        }
        public void GenerateData()
        {
            MainCollection.Add(new Manga("OnePiece", false, "Manga", "Eichiro Oda", "../Image/onepiece1.jpg", new List<EditionInfo>()));

            MainCollection.Add(new Manga("InuYasha", true, "Manga", "Rumiko Takahashi", "../Image/inuyasha1.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Manga("Battle Angel Alita", true, "Manga", "Yukito Kishiro", "../Image/alita1.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Manga("Candidate for Goddess", true, "Manga", "Yukiru Sugisaki", "../Image/goddess1.jpg", new List<EditionInfo>()));
           
            MainCollection.Add(new Manga("Bleach", false, "Manga", "Tite Kubo", "../Image/bleach1.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Manga("Fairy Tail", true, "Manga", "Hiro Mashima", "../Image/fairytail1.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Manga("My Hero Academia", false, "Manga", "Kohei Horikoshi", "../Image/academia1.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Manga("Hellsing", false, "Manga", "Kota Hirano", "../Image/hellsing1.jpg", new List<EditionInfo>()));

            MainCollection.Add(new Anime("Chihiros Reise ins Zauberland", true, "Anime", "Film", "Hayao Miyazaki", "../Image/chihiro.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Anime("Prinzessin Mononoke", true, "Anime", "Film", "Hayao Miyazaki", "../Image/mononoke.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Anime("Samurai Champloo", true, "Anime", "Serie", "Shin'ichiro Watanabe", "../Image/champloo1.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Anime("Cowboy Bebop", true, "Anime", "Film", "Shin'ichiro Watanabe", "../Image/bebop1.jpg", new List<EditionInfo>()));
            
            MainCollection.Add(new Anime("Ranma 1/2", false, "Anime", "Serie", "Rumiko Takahashi", "../Image/ranma.jpg", new List<EditionInfo>()));


            Collectible entry = this.SelectEntry("OnePiece");
            //Collectible entry = MainCollection.FirstOrDefault(a => a.Title_German == "OnePiece");
            entry.EditionInfo.Add(new MangaEditionInfo(1, 1, 7.19, "Das Abenteuer beginnt", 1, 5, false,"../Image/onepiece1.jpg"));
            entry.EditionInfo.Add(new MangaEditionInfo(2, 1, 7.19, "Ruffy versus Buggy der Clown", 6, 10, false, "../Image/onepiece2.jpg"));
            entry.EditionInfo.Add(new MangaEditionInfo(3, 1, 7.19, "Die Suche geht weiter", 11, 15, false, "../Image/onepiece3.jpg"));
            entry.EditionInfo.Add(new MangaEditionInfo(4, 1, 7.19, "Wolf im Schafspelz", 16, 20, false, "../Image/onepiece4.jpg"));
            entry.EditionInfo.Add(new MangaEditionInfo(5, 1, 7.19, "Wem schlägt jetzt die Stunde", 21, 25, false, "../Image/onepiece5.jpg"));
            Collectible entry1 = this.SelectEntry("Chihiros Reise ins Zauberland");
            entry1.EditionInfo.Add(new AnimeEditionInfo(1, 1, 23.18, "BlueRay", 1, 1, "Studio Ghibli", "../Image/chihiro.jpg"));
            Collectible entry2 = this.SelectEntry("Samurai Champloo");
            entry2.EditionInfo.Add(new AnimeEditionInfo(1, 1, 18.99, "DVD", 1, 4, "../Image/champloo1.jpg"));
            entry2.EditionInfo.Add(new AnimeEditionInfo(2, 1, 18.99, "DVD", 5, 8, "../Image/champloo2.jpg"));
            entry2.EditionInfo.Add(new AnimeEditionInfo(3, 1, 18.99, "DVD", 9, 12, "../Image/champloo3.jpg"));
            entry2.EditionInfo.Add(new AnimeEditionInfo(4, 1, 18.99, "DVD", 13, 16, "Der Sommer der Liebe", "../Image/champloo4.jpg"));
            entry2.EditionInfo.Add(new AnimeEditionInfo(5, 1, 18.99, "DVD", 17, 20, "../Image/champloo5.jpg"));
            entry2.EditionInfo.Add(new AnimeEditionInfo(6, 1, 18.99, "DVD", 21, 24, "../Image/champloo6.jpg"));
            entry2.EditionInfo.Add(new AnimeEditionInfo(7, 1, 18.99, "DVD", 25, 28, "../Image/champloo7.jpg"));
            entry2.EditionInfo.Add(new AnimeEditionInfo(8, 1, 18.99, "DVD", 29, 32, "../Image/champloo8.jpg"));


        }

        public Collectible SelectEntry(string value)
        {
            Collectible entry = MainCollection.FirstOrDefault(a => a.Title_German == value);
            return entry;
        }
        
        public void ShowMangaCollection()
        {
            foreach (Collectible col in MainCollection)
            {
                if (col is Manga manga)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + manga.CollectiblesID);
                    Console.WriteLine("Titel (deutsch): " + manga.Title_German);
                    Console.WriteLine("Titel (japanisch): " + manga.Title_Japanese);
                    Console.WriteLine("Abgeschlossen: " + manga.Finalised);
                    Console.WriteLine("Autor: " + manga.Autor);
                }
            }
        }

        public void ShowAnimeCollection()
        {
            foreach (Collectible col in MainCollection)
            {
                if (col is Anime anime)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + anime.CollectiblesID);
                    Console.WriteLine("Titel (deutsch): " + anime.Title_German);
                    Console.WriteLine("Titel (japanisch): " + anime.Title_Japanese);
                    Console.WriteLine("Abgeschlossen: " + anime.Finalised);
                    Console.WriteLine("Regisseur: " + anime.Director);
                }
            }
        }

        public void ShowEditionInfoByID(int id)
        {
            Collectible series = MainCollection.FirstOrDefault(a => a.CollectiblesID == id);
            foreach (EditionInfo info in series.EditionInfo)
            {
                Console.WriteLine();
                Console.WriteLine("Volume: " + info.Volume);
                Console.WriteLine("Menge: " + info.Amount);
                Console.WriteLine("Preis: " + info.Price + " Euro");
                if (info is MangaEditionInfo MEI)
                {
                    Console.WriteLine("Titel: " + MEI.Title);
                    Console.WriteLine("Kapitel: " + MEI.StartChapter + " - " + MEI.EndChapter);
                    Console.WriteLine("Erstausgabe: " + MEI.FirstEdition);
                }
                if (info is AnimeEditionInfo AEI)
                {
                    Console.WriteLine("Speichermedium: " + AEI.StorageMedium);
                    if (AEI.Startepisode != AEI.Endepisode)
                    {
                        Console.WriteLine("Episoden: " + AEI.Startepisode + " - " + AEI.Endepisode);
                    }
                    else
                    {
                        Console.WriteLine("Episode: " + AEI.Startepisode);
                    }
                    Console.WriteLine("Notizen: " + AEI.Notes);
                }
            }
        }

        public void ShowStatistic()
        {
            int mangaseries = 0;
            int mangafinalised = 0;
            int mangavolumes = 0;
            double mangacost = 0;
            int animemovies = 0;
            int animeseries = 0;
            double animecost = 0;
            double totalcost = 0;
            foreach (Collectible col in MainCollection)
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
            }
            totalcost = mangacost + animecost;
            //Console.WriteLine("Anzahl der Mangareihen: " + mangaseries);
            //Console.WriteLine("davon abgeschlossen: " + mangafinalised);
            //Console.WriteLine("Anzahl aller Bänder: " + mangavolumes);
            //Console.WriteLine("");
            //Console.WriteLine("Manga-Kosten: " + mangacost);
            //Console.WriteLine("");
            //Console.WriteLine("Anzahl der Animefilme: " + animemovies);
            //Console.WriteLine("Anzahl der Animeserien: " + animeseries);
            //Console.WriteLine("");
            //Console.WriteLine("Anime-Kosten: " + animecost);
            //Console.WriteLine("");
            //Console.WriteLine("Gesamtkosten: " + totalcost);
        }
    }
}
