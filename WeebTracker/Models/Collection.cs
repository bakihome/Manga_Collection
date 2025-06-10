using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PrivateCollection : IEnumerable<KeyValuePair<Collectible, List<EditionInfo>>>
    {
        public Dictionary<Collectible, List<EditionInfo>> MainCollection = new Dictionary<Collectible, List<EditionInfo>>();

        //public List<Collectibles> MainCollection = new List<Collectibles>();
        private static int ID;


        public IEnumerator<KeyValuePair<Collectible, List<EditionInfo>>> GetEnumerator()
        {
            return MainCollection.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return MainCollection.GetEnumerator();
        }

        public void GenerateData()
        {
            MainCollection.Add(new Manga("OnePiece", false, "Manga", "Eichiro Oda"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Manga( "InuYasha", true, "Manga", "Rumiko Takahashi"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Manga("Battle Angel Alita", true, "Manga", "Yukito Kishiro"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Manga("Candidate for Goddess", true, "Manga", "Yukiru Sugisaki"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Manga("Bleach", false, "Manga", "Tite Kubo"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Manga("Fairy Tail", true, "Manga", "Hiro Mashima"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Manga("My Hero Academia", false, "Manga", "Kohei Horikoshi"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Manga("Hellsing", false, "Manga", "Kota Hirano"), new List<EditionInfo>());
            ID++;

            MainCollection.Add(new Anime("Chihiros Reise ins Zauberland", true, "Anime", "Film", "Hayao Miyazaki"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Anime("Prinzessin Mononoke", true, "Anime", "Film", "Hayao Miyazaki"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Anime("Samurai Champloo", true, "Anime", "Serie", "Shin'ichiro Watanabe"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Anime("Cowboy Bebop", true, "Anime", "Serie", "Shin'ichiro Watanabe"), new List<EditionInfo>());
            ID++;
            MainCollection.Add(new Anime("Ranma 1/2", false, "Anime", "Serie", "Rumiko Takahashi"), new List<EditionInfo>());
            ID++;

            //KeyValuePair<Collectible, List<EditionInfo>> entry = this.SelectEntry(0);
            ////MainCollection.FirstOrDefault(kvp => kvp.Key.CollectibleID == 0);
            //entry.Value.Add(new MangaEditionInfo(1, 1, 7.19, "Das Abenteuer beginnt", 1, 5, false));
            //entry.Value.Add(new MangaEditionInfo(2, 1, 7.19, "Ruffy versus Buggy der Clown", 6, 10, false));
            //entry.Value.Add(new MangaEditionInfo(3, 1, 7.19, "Die Suche geht weiter", 11, 15, false));
            //entry.Value.Add(new MangaEditionInfo(4, 1, 7.19, "Wolf im Schafspelz", 16, 20, false));
            //entry.Value.Add(new MangaEditionInfo(5, 1, 7.19, "Wem schlägt jetzt die Stunde", 21, 25, false));
            //KeyValuePair<Collectible, List<EditionInfo>> entry1 = this.SelectEntry(9);
            //entry1.Value.Add(new AnimeEditionInfo(1, 1, 23.18, "BlueRay", 1, 1, "Studio Ghibli"));
            //KeyValuePair<Collectible, List<EditionInfo>> entry2 = this.SelectEntry(10);
            //entry2.Value.Add(new AnimeEditionInfo(1, 1, 18.99, "DVD", 1, 4));
            //entry2.Value.Add(new AnimeEditionInfo(2, 1, 18.99, "DVD", 5, 8));
            //entry2.Value.Add(new AnimeEditionInfo(3, 1, 18.99, "DVD", 9, 12));
            //entry2.Value.Add(new AnimeEditionInfo(4, 1, 18.99, "DVD", 13, 16, "Der Sommer der Liebe"));
            //entry2.Value.Add(new AnimeEditionInfo(5, 1, 18.99, "DVD", 17, 20));
            //entry2.Value.Add(new AnimeEditionInfo(6, 1, 18.99, "DVD", 21, 24));
            //entry2.Value.Add(new AnimeEditionInfo(7, 1, 18.99, "DVD", 25, 28));
            //entry2.Value.Add(new AnimeEditionInfo(8, 1, 18.99, "DVD", 29, 32));


        }       

        public KeyValuePair<Collectible, List<EditionInfo>> SelectEntry(int id)
        {
            KeyValuePair<Collectible, List<EditionInfo>> entry = MainCollection.FirstOrDefault(kvp => kvp.Key.CollectiblesID == id);
            return entry;
        }

        public void ShowMangaCollection()
        {
            foreach (KeyValuePair<Collectible, List<EditionInfo>> kvp in MainCollection)
            {
                if (kvp.Key is Manga manga)
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
            foreach (KeyValuePair<Collectible, List<EditionInfo>> kvp in MainCollection)
            {
                if (kvp.Key is Anime anime)
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
            KeyValuePair<Collectible, List<EditionInfo>> series = MainCollection.FirstOrDefault(kvp => kvp.Key.CollectiblesID == id);
            foreach (EditionInfo info in series.Value)
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
            foreach (KeyValuePair<Collectible, List<EditionInfo>> kvp in MainCollection)
            {
                if (kvp.Key.Medium == "Manga")
                {
                    mangaseries++;
                    if (kvp.Key.Finalised)
                    {
                        mangafinalised++;
                    }
                }
                else
                {
                    if (kvp.Key is Anime anime)
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


                if (kvp.Value.Count > 0)
                {
                    foreach (EditionInfo info in kvp.Value)
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
            Console.WriteLine("Anzahl der Mangareihen: " + mangaseries);
            Console.WriteLine("davon abgeschlossen: " + mangafinalised);
            Console.WriteLine("Anzahl aller Bänder: " + mangavolumes);
            Console.WriteLine("");
            Console.WriteLine("Manga-Kosten: " + mangacost);
            Console.WriteLine("");
            Console.WriteLine("Anzahl der Animefilme: " + animemovies);
            Console.WriteLine("Anzahl der Animeserien: " + animeseries);
            Console.WriteLine("");
            Console.WriteLine("Anime-Kosten: " + animecost);
            Console.WriteLine("");
            Console.WriteLine("Gesamtkosten: " + totalcost);
        }
    }
}
