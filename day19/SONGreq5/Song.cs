using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace songreq_3
{
    class Song
    {
        private string _name;
        private string _artist;
        private string _songType;
        private double _rating;
        private int _numberOfDownloads;
        private DateTime _dateDownloaded;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }


        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }


        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }
        }

        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }

        public Song()
        {

        }
        public Song(string _name, string _artist, string _songType, double _rating, int _numberOfDownloads, DateTime _dateDownloaded)
        {
            Name = _name;
            Artist = _artist;
            SongType = _songType;
            Rating = _rating;
            NumberOfDownloads = _numberOfDownloads;
            DateDownloaded = _dateDownloaded;


        }

        public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            foreach (Song songs in list)
            {
                if (sd.ContainsKey(songs.SongType))
                    sd[songs.SongType]++;
                else

                    sd[songs.SongType] = 1;

            }
                Console.WriteLine("SongType   \tCount");
                foreach (KeyValuePair<string, int> kvp in sd)
                {
                    Console.WriteLine("{0} \t\t{1}", kvp.Key, kvp.Value);
                }

                return sd;

            
        }


    }
}






