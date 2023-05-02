using songreq_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SONGreq5
{
   class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = Songrepo.GetSongs();

            SortedDictionary<string, int> sd = Song.CalculateTypeCount(songs);


            
        }
    }
}
