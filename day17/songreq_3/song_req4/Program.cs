using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace song_req4
{
    internal class Program
    
         {

    static void Main(string[] args)

        {

            List<Song> songs = Songrepo.GetSongs();

            Song s = new Song();

            SongBO sbo = new SongBO();

            // Print the details of each song to the console

            //foreach (Songs song in songs)

            //{

            // Console.WriteLine(song);

            //}

            //Name sort

            int ch;

            do

            {

                Console.WriteLine();

                Console.WriteLine("Enter your choice :");

                Console.WriteLine();

                Console.WriteLine("1: Sort By Name\n 2: Sort By Rating \n 3: Sort By Popularity \n 4: Exit");

                Console.WriteLine();

                ch = int.Parse(Console.ReadLine());

                switch (ch)

                {

                    case 1:

                        songs.Sort();

                        Console.WriteLine();

                        Console.WriteLine("------Sorted Result of Names-----");

                        Console.WriteLine();

                        Console.WriteLine("Name\t\tArtist\t SongType\t Rating\t NumberofDownloads\t DateDownloaded");

                        Console.WriteLine();

                        foreach (Song songs1 in songs)

                        {

                            Console.WriteLine(songs1);

                        }

                        break;

                    case 2:

                        songs.Sort(new RatingComparer());

                        Console.WriteLine();

                        Console.WriteLine("-----Sorted Result of Ratings--------");

                        Console.WriteLine();

                        Console.WriteLine("Name\t\tArtist\t SongType\t Rating\t NumberofDownloads\t DateDownloaded");

                        Console.WriteLine();

                        foreach (Song songs1 in songs)

                        {

                            Console.WriteLine(songs1);

                        }

                        break;

                    case 3:

                        songs.Sort(new PopularityComparer());

                        Console.WriteLine();

                        Console.WriteLine("-------Sorted Result of Popularity-----");

                        Console.WriteLine();

                        Console.WriteLine("Name\t\tArtist\t SongType\t Rating\t NumberofDownloads\t DateDownloaded");

                        Console.WriteLine();

                        foreach (Song songs1 in songs)

                        {

                            Console.WriteLine(songs1);

                        }

                        break;

                    case 4:

                        break;

                        //Rate Comparer

                        //sorted list of Popularity

                }

            }

            while (ch != 0);

            Console.ReadKey();

        }

    }

}

