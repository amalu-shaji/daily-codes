using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace songreq_3
{
    class Program

    {

        static void Main(string[] args)

        {

            List<Song> ls = Songrepo.GetSongs();

            //foreach(Song S in ls)

            //{

            // Console.WriteLine(S.ToString());

            //}

            

            Song s = new Song();

            SongBO s1 = new SongBO();
            int ch;
            do

            {
                Console.WriteLine("\n1.Song Type");

                Console.WriteLine("\n2.Date of download");

                Console.WriteLine("\n3.Rating");

                Console.WriteLine("\nEnter your choice:");

                ch = int.Parse(Console.ReadLine());

                switch (ch)

                {

                    case 1:

                        Console.WriteLine("Enter the type:");

                        s.SongType = Console.ReadLine();

                        List<Song> songs1 = SongBO.FindSong(ls, s.SongType);
                        Console.WriteLine("Name\t\tArtist\t\tSongType\tRating\tNumberofDownloads\t\tDateDowloaded");
                        foreach (Song S in songs1)

                        {

                            Console.WriteLine(S.ToString());

                        }

                        break;

                    case 2:

                        Console.WriteLine("Enter the date:");

                        s.DateDownloaded = DateTime.Parse(Console.ReadLine());

                        List<Song> songs2 = s1.FindSong(ls, s.DateDownloaded);

                        foreach (Song S in songs2)

                        {

                            Console.WriteLine(S.ToString());

                        }

                        break;

                    case 3:

                        Console.WriteLine("Enter the Rating:");

                        s.Rating = double.Parse(Console.ReadLine());

                        List<Song> songs3 = s1.FindSong(ls, s.Rating);

                        foreach (Song S in songs3)

                        {

                            Console.WriteLine(S.ToString());

                        }

                        break;

                }

            } while (ch != 0);

            Console.WriteLine("wrong choice");

        }

    }

}