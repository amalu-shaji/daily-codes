using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace song_req4
{
   public class Song: IComparable<Song>
         
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
        public override string ToString()
        {
            return string.Format("{0} \t{1} \t{2} \t{3} \t{4} \t\t\t\t{5}", Name, Artist, SongType, Rating, NumberOfDownloads, DateDownloaded.ToString("dd-MM-yyyy", null));
        }

        public int CompareTo(Song other)
        {

            return Name.CompareTo(other.Name);
        }




    }
}

