using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Artist
    {
        public string Name { get; }

        City Hometown;
        int  DateOfBirth;
        List<Masterpiece> ArtWorks = new List<Masterpiece>();

        public Artist(string HisName)
        {
            Name = HisName;
        }

        public Artist(string HisName, City BirthPlace, int  BirthTime)
        {
            Name = HisName;
            Hometown = BirthPlace;
            DateOfBirth = BirthTime;
        }
    }
}
